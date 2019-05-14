using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA19_Manager
{
    public partial class MainForm : Form
    {

        private Player selected;
        private PlayerBL bl;
        private PositionBox selectedTF;
        public string TeamName { get; set; }

        /// <summary>
        /// In the constructor, a new "PlayerBL" object is created and the load function for reading in the
        /// players is called. If the file is not found and error message is displayed.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            bl = new PlayerBL(liPlayer);
            try
            {
                bl.load();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n"+ex.StackTrace);
            }

        }

        /// <summary>
        /// The add button event is for adding the currently selected player to a specific location (textBox).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bl.setPlayerOnPosition(selected, selectedTF.Pos);
                selectedTF.Text = selected.Name;
                
            } catch (ArgumentNullException)
            {
                MessageBox.Show("You have to select a player and a position before you can add!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The match button event opens a new form, where you can select two created teams. After that, a match
        /// is simulated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMatch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///  The function is called to store the team in the database.
        /// </summary>
        public void storeTeam()
        {
            try
            {
                Team team = bl.getCurrentTeam();
                team.Name = TeamName;
                team.CalcScore();
                DataBaseManager.addTeam(team);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// The create button event checks if any positions are empty. If there are some empty ones, an error message
        /// is displayed. After checking an input window is opened, where the user is able to input the name of the
        /// team. Then the team is stored into a database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreate_Click(object sender, EventArgs e)
        {
            Team team = bl.getCurrentTeam();
            try
            {
                team.CheckIfComplete();
                InputForm form = new InputForm(this);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The focus entered event is triggered by all positionboxes. When the event is called, the sender is set as
        /// the selectedTF.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tfPositions_FocusEntered(object sender, EventArgs e)
        {
            selectedTF = (PositionBox)sender;
        }

        /// <summary>
        /// This event is for filtering the ListBox. It calls the "filter" function in the bl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btName_TextChanged(object sender, EventArgs e)
        {
            bl.filter(tfName.Text, tfNation.Text, tfClub.Text);
        }

        /// <summary>
        /// This event is for filtering the ListBox. It calls the "filter" function in the bl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNation_TextChanged(object sender, EventArgs e)
        {
            bl.filter(tfName.Text, tfNation.Text, tfClub.Text);
        }

        /// <summary>
        /// This event is for filtering the ListBox. It calls the "filter" function in the bl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClub_TextChanged(object sender, EventArgs e)
        {
            bl.filter(tfName.Text, tfNation.Text, tfClub.Text);
        }

        /// <summary>
        /// The index changed event is for displaying information about a player. After the currently selected player
        /// is stored in the "selected" attribute, the program tries to put the images of the player and the club
        /// into the pictureBoxes. If they were not downloaded yet, a webclient downloads them and stores them into the
        /// "Downloads" folder. If there was a picture of the player or the club in the internet, the program sets it
        /// for the pictureBox, if there wasn't, a "404 Not Found" picture is displayed instead.
        /// The function also displays information about the name, nationality and overall score of the player. Depending
        /// on the overall score, the backgroundcolor of the PlayerPanel changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void liPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = bl.getPlayerAtIndex(liPlayer.SelectedIndex);
            using (WebClient client = new WebClient())
            {
                try
                {
                    try
                    {
                        picture.Image = GetCopyImage("./Downloads/" + selected.ID.ToString() + "Photo.png");
                    }
                    catch (FileNotFoundException)
                    {
                        client.DownloadFile(new Uri(selected.PhotoURL), "./Downloads/" + selected.ID.ToString() + "Photo.png");
                        picture.Image = GetCopyImage("./Downloads/" + selected.ID.ToString() + "Photo.png");
                    }
                }
                catch (Exception)
                {
                    picture.Image = Image.FromFile("./Error/404.png");
                }
                try
                {
                    try
                    {
                        club.Image = GetCopyImage("./Downloads/" + selected.ID.ToString() + "Club.png");

                    }
                    catch (FileNotFoundException)
                    {
                        client.DownloadFile(new Uri(selected.ClubURL), "./Downloads/" + selected.ID.ToString() + "Club.png");
                        club.Image = GetCopyImage("./Downloads/" + selected.ID.ToString() + "Club.png");
                    }
                }
                catch (Exception)
                {
                    club.Image = Image.FromFile("./Error/404.png");
                }
            }
            lbNationality.Text = selected.Nationality;
            lbName.Text = selected.Name;
            lbOverall.Text = selected.Overall.ToString();
            if(selected.Overall > 79)
            {
                PlayerPanel.BackColor = Color.Gold;
            } else if (selected.Overall > 59)
            {
                PlayerPanel.BackColor = Color.Silver;
            } else
            {
                PlayerPanel.BackColor = Color.SaddleBrown;
            }
        }

        /// <summary>
        /// The function makes a copy of a image and returns it as a bitmap. In this way, the image is not directly
        /// used by the program.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        /// <summary>
        /// In order to save disk space, the "Downloads" folder is cleared when closing the form. Due to the fact that
        /// only copies of the pictures are used in the pictureBoxes, the program can simply access the images and
        /// delete them.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeletePictures(object sender, FormClosingEventArgs e)
        {
            picture.Image = null;
            club.Image = null;
            System.IO.DirectoryInfo di = new DirectoryInfo("./Downloads/");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }
    }
}
