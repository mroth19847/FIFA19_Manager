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

        /// <summary>
        /// The function adds wins, loses or draw to the team objects, which participated in a match. It returns
        /// one object which is selected in the GUI after the result was saved.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public Team manageResult(Result r)
        {
            try
            {
                if (r.getWinner() == null)
                {
                    teams[getIndexOfTeam(r.Team1)].Draw++;
                    teams[getIndexOfTeam(r.Team2)].Draw++;
                    update();
                    DataBaseManager.updateTeam(r.Team1.ID, teams[getIndexOfTeam(r.Team1)].Won,
                                                           teams[getIndexOfTeam(r.Team1)].Lost,
                                                           teams[getIndexOfTeam(r.Team1)].Draw);
                    DataBaseManager.updateTeam(r.Team2.ID, teams[getIndexOfTeam(r.Team2)].Won,
                                                           teams[getIndexOfTeam(r.Team2)].Lost,
                                                           teams[getIndexOfTeam(r.Team2)].Draw);
                    return teams[getIndexOfTeam(r.Team1)];
                }
                teams[getIndexOfTeam(r.getWinner())].Won++;
                teams[getIndexOfTeam(r.getLoser())].Lost++;
                update();
                DataBaseManager.updateTeam(r.Team1.ID, teams[getIndexOfTeam(r.Team1)].Won,
                                       teams[getIndexOfTeam(r.Team1)].Lost,
                                       teams[getIndexOfTeam(r.Team1)].Draw);
                DataBaseManager.updateTeam(r.Team2.ID, teams[getIndexOfTeam(r.Team2)].Won,
                                                       teams[getIndexOfTeam(r.Team2)].Lost,
                                                       teams[getIndexOfTeam(r.Team2)].Draw);
                return teams[getIndexOfTeam(r.getWinner())];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// The function returns the index of a specific object in the list.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private int getIndexOfTeam(Team t)
        {
            for(int i = 0; i<teams.Count(); i++)
            {
                if (t.ID == teams[i].ID)
                {
                    return i;
                }
            }
            throw new Exception("Team is not in the list!");
        }
    }
}
