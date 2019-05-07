using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA19_Manager
{
    /// <summary>
    /// For every team, a individual ID is generated for the database. Every Team does also have a name and a
    /// score, which is build up using the scores of the Players on each position.
    /// </summary>
    public class Team
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public int Score { get; set; }

        public Player GK { get; set; }

        public Player ST { get; set; }

        public Player LS { get; set; }

        public Player RS { get; set; }

        public Player ZMR { get; set; }

        public Player ZML { get; set; }

        public Player ZDM { get; set; }

        public Player LV { get; set; }

        public Player RV { get; set; }

        public Player IVR { get; set; }

        public Player IVL { get; set; }


        /// <summary>
        /// The CalcScore function calculates the score of the team. It uses the values stored in the Player
        /// objects and adds them.
        /// </summary>
        public void CalcScore()
        {
            int sum = 0;
            sum += GK.GKval;
            sum += ST.STval;
            sum += LS.LSval;
            sum += RS.RSval;
            sum += ZMR.ZMval;
            sum += ZML.ZMval;
            sum += ZDM.ZDMval;
            sum += LV.LVval;
            sum += RV.RVval;
            sum += IVR.IVval;
            sum += IVL.IVval;
            Score = sum;
        }

    }
}
