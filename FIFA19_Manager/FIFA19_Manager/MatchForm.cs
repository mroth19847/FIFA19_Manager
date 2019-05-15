using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA19_Manager
{
    public partial class MatchForm : Form
    {

        private TeamBL bl;
        private Team selected;
        private Team t1;
        private Team t2;

        /// <summary>
        /// In teh constructor, the bl object is initialized with the teams in the database and the list is refreshed.
        /// </summary>
        public MatchForm()
        {
            InitializeComponent();
            try
            {
                bl = new TeamBL(liTeams);
                bl.update();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The function sets the text of the information text fields. It also stores the selected team object into the "selected"
        /// attribute.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void liTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = bl.getTeamAt(liTeams.SelectedIndex);
            tfName.Text = selected.Name;
            tfScore.Text = selected.Score.ToString();
            tfWon.Text = selected.Won.ToString();
            tfLost.Text = selected.Lost.ToString();
            tfDraw.Text = selected.Draw.ToString();
        }

        /// <summary>
        /// The function sets the selected team to the textfield which is clicked. If no team is selected or the team is already
        /// in the match, an error message is shown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tfTeam2_Enter(object sender, EventArgs e)
        {
            if(selected == null)
            {
                MessageBox.Show("You haven't selected a team!");
            } else if(t1 == selected || t2 == selected)
            {
                MessageBox.Show("The team already participates in the match!");
            } else
            {
                TextBox tf = (TextBox)sender;
                tf.Text = selected.Name;
                if (tf == tfTeam1) t1 = selected;
                else t2 = selected;
            }
        }

        /// <summary>
        /// The function creates a Match-object using the two team objects. In the beginning, it checks if the two textboxes are
        /// filled, then the match class simulates a match using threads and outputs the results in the textbox taOutput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btStart_Click(object sender, EventArgs e)
        {
            Match match = new Match { Team1 = t1, Team2 = t2 };
            Thread thread = new Thread(new ThreadStart(match.Simulate));
            thread.Start();
        }
    }
}
