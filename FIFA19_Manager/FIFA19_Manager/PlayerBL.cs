using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA19_Manager
{
    public class PlayerBL
    {
        private List<Player> players = new List<Player>();
        private List<Player> filtered = new List<Player>();
        private ListBox ListB;

        public PlayerBL(ListBox listB)
        {
            this.ListB = listB;
        }

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
                            Overall = Convert.ToInt32(parts[7]),
                            STval = Convert.ToInt32(parts[29]),
                            LSval = Convert.ToInt32(parts[28]),
                            RSval = Convert.ToInt32(parts[30]),
                            ZMval = Convert.ToInt32(parts[41]),
                            ZDMval = Convert.ToInt32(parts[46]),
                            RVval = Convert.ToInt32(parts[53]),
                            LVval = Convert.ToInt32(parts[49]),
                            IVval = Convert.ToInt32(parts[51])
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

        public void filter(string name, string nation, string club)
        { 

        }

        public void reset()
        {

        }

        public void update()
        {
            ListB.BeginUpdate();
            ListB.Items.Clear();
            foreach (Player pl in filtered)
            {
                ListB.Items.Add(pl);
            }
            ListB.EndUpdate();
        }

    }
}
