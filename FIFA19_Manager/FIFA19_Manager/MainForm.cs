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

        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void btMatch_Click(object sender, EventArgs e)
        {

        }

        private void btCreate_Click(object sender, EventArgs e)
        {

        }

        private void btName_TextChanged(object sender, EventArgs e)
        {
            bl.filter(tfName.Text, tfNation.Text, tfClub.Text);
        }

        private void btNation_TextChanged(object sender, EventArgs e)
        {
            bl.filter(tfName.Text, tfNation.Text, tfClub.Text);
        }

        private void btClub_TextChanged(object sender, EventArgs e)
        {
            bl.filter(tfName.Text, tfNation.Text, tfClub.Text);
        }

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

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

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
