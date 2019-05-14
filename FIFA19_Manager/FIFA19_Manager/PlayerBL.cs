using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA19_Manager
{
    public enum Position { GK, RV, IVR, IVL, LV, ZDM, ZMR, ZML, RS, LS, ST };

    public class PlayerBL
    {
        private static List<Player> players = new List<Player>();
        private List<Player> filtered = new List<Player>();
        private Team currentTeam = new Team();
        private ListBox ListB;

        /// <summary>
        /// The function sets a specific player at a specific position in the team, tests if the player is already in the team
        /// and removes players from the team if another player is set on his position.
        /// </summary>
        /// <param name="pl"></param>
        /// <param name="pos"></param>
        public void setPlayerOnPosition(Player pl, Position pos)
        {
            if(!currentTeam.checkIfPlayerIsAvailable(pl)) throw new Exception("You can't use one player for more positions! To change the position of this player, you have to set a player for his position, then you can use him again!");

            switch (pos)
            {
                case Position.GK: currentTeam.removePlayer(currentTeam.GK); currentTeam.GK = pl; break;
                case Position.RV: currentTeam.removePlayer(currentTeam.RV); currentTeam.RV = pl; break;
                case Position.IVR: currentTeam.removePlayer(currentTeam.IVR); currentTeam.IVR = pl; break;
                case Position.IVL: currentTeam.removePlayer(currentTeam.IVL); currentTeam.IVL = pl; break;
                case Position.LV: currentTeam.removePlayer(currentTeam.LV); currentTeam.LV = pl; break;
                case Position.ZDM: currentTeam.removePlayer(currentTeam.ZDM); currentTeam.ZDM = pl; break;
                case Position.ZMR: currentTeam.removePlayer(currentTeam.ZMR); currentTeam.ZMR = pl; break;
                case Position.ZML: currentTeam.removePlayer(currentTeam.ZML); currentTeam.ZML = pl; break;
                case Position.RS: currentTeam.removePlayer(currentTeam.RS); currentTeam.RS = pl; break;
                case Position.ST: currentTeam.removePlayer(currentTeam.ST); currentTeam.ST = pl; break;
                case Position.LS: currentTeam.removePlayer(currentTeam.LS); currentTeam.LS = pl; break;
                default: throw new Exception("Position not found!");
            }

            currentTeam.addPlayer(pl);
        }

        /// <summary>
        /// The constructor includes a ListBox parameter, which is essential for refreshing the list after
        /// loading or filtering the players.
        /// </summary>
        /// <param name="listB"></param>
        public PlayerBL(ListBox listB)
        {
            this.ListB = listB;
        }

        /// <summary>
        /// This function is a getter for the team which is currently built.
        /// </summary>
        /// <returns></returns>
        public Team getCurrentTeam()
        {
            return currentTeam;
        }

        /// <summary>
        /// The function returns the player of a specific index.
        /// The function is necessary for displaying information about a player.
        /// </summary>
        /// <param name="i"></param>
        /// <returns> Returns a Player object</returns>
        public Player getPlayerAtIndex(int i)
        {
            return filtered[i];
        }

        /// <summary>
        /// The function loads data from a csv file. For each line, player object is created
        /// with the essential information and stored in the "players" and the "filtered" list.
        /// </summary>
        public void load()
        {
            try
            {


                using (StreamReader sr = new StreamReader("./data.csv"))
                {
                    string line = sr.ReadLine();

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        Player pl = new Player
                        {
                            ID = Convert.ToInt32(parts[1]),
                            Name = parts[2],
                            PhotoURL = parts[4],
                            Nationality = parts[5],
                            Club = parts[9],
                            ClubURL = parts[10],
                            Overall = getPositionValue(parts[7]),
                            STval = getPositionValue(parts[30]),
                            LSval = getPositionValue(parts[29]),
                            RSval = getPositionValue(parts[31]),
                            ZMval = getPositionValue(parts[42]),
                            ZDMval = getPositionValue(parts[47]),
                            RVval = getPositionValue(parts[54]),
                            LVval = getPositionValue(parts[50]),
                            IVval = getPositionValue(parts[52])
                        };

                        if (parts[21].Equals("GK"))
                        {
                            pl.GKval = pl.Overall;
                        }
                        else
                        {
                            pl.GKval = 0;
                        }
                        players.Add(pl);
                        filtered.Add(pl);
                    }
                }
                update();
            
            }
            catch (FileNotFoundException)
            {
                throw new Exception("The program failed to read the player data. Please restart and try again!");
            }
        }

        /// <summary>
        /// For some reason, the scores on the positions of the players are badly formatted. This
        /// function return the integer value for a string including the badly formatted score.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns>Returns an integer</returns>
        private int getPositionValue(string pos)
        {
            if (pos.Equals(""))
            {
                return 0;
            } else if (pos.Contains("+"))
            {
                string[] parts = pos.Split('+');
                return Convert.ToInt32(parts[0]) + Convert.ToInt32(parts[1]);
            }
            return Convert.ToInt32(pos);
        }

        /// <summary>
        /// This function edits the "filtered" list. It is called in from the GUI. After checking if the
        /// information given in the parameters is contained in an object, it is added to the "filtered"
        /// list.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="nation"></param>
        /// <param name="club"></param>
        public void filter(string name, string nation, string club)
        {
            filtered.Clear();
            foreach (Player pl in players)
            {
                if (pl.Name.ToLower().Contains(name.ToLower()) &&
                   pl.Club.ToLower().Contains(club.ToLower()) &&
                   pl.Nationality.ToLower().Contains(nation.ToLower()))
                {
                    filtered.Add(pl);
                }
            }
            update();
        }

        /// <summary>
        /// The "update" function is for refreshing the ListBox, which is stored as a global attribute.
        /// </summary>
        private void update()
        {
            ListB.BeginUpdate();
            ListB.Items.Clear();
            foreach (Player pl in filtered)
            {
                ListB.Items.Add(pl);
            }
            ListB.EndUpdate();
        }

        /// <summary>
        /// The function returns a player object using the id. It is used to build up the team objects after
        /// reading the data from the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Player getPlayerObject(object id)
        {
            int id1 = Convert.ToInt32(id);
            foreach (Player player in players)
            {
                if(player.ID == id1)
                {
                    return player;
                }
            }
            throw new Exception("Player not found!");
        }

    }
}
