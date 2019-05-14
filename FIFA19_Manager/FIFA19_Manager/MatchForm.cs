using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA19_Manager
{
    public partial class MatchForm : Form
    {

        private TeamBL bl;
        private Team selected;

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
    }
}
