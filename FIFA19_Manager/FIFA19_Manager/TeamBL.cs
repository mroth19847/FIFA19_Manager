using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA19_Manager
{
    public class TeamBL
    {
        private List<Team> teams = new List<Team>();
        private ListBox ListB;

        /// <summary>
        /// In the constructor the list is initialized using the "getStoredTeams" function in the DataBaseManager.
        /// Also the ListBox is initialized.
        /// </summary>
        /// <param name="listB"></param>
        public TeamBL(ListBox listB)
        {
            try
            {
                this.ListB = listB;
                teams = DataBaseManager.getStoredTeams();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// The function returns a team object at a specific index.
        /// /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public Team getTeamAt(int idx)
        {
            return teams[idx];
        }

        /// <summary>
        /// The "update" function is for refreshing the ListBox, which is stored as a global attribute.
        /// </summary>
        public void update()
        {
            ListB.BeginUpdate();
            ListB.Items.Clear();
            foreach (Team team in teams)
            {
                ListB.Items.Add(team);
            }
            ListB.EndUpdate();
        }


    }
}
