using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA19_Manager
{
    public class Result
    {
        public int Score1 { get; set; }

        public int Score2 { get; set; }

        public Team Team1 { get; set; }

        public Team Team2 { get; set; }

        /// <summary>
        /// Returns the winner as a team object regarding to the scores.
        /// </summary>
        /// <returns></returns>
        public Team getWinner()
        {
            if (Score1 > Score2) return Team1;
            if (Score2 > Score1) return Team2;
            return null;
        }

        /// <summary>
        /// Returns the loset as a team object regarding to the scores.
        /// </summary>
        /// <returns></returns>
        public Team getLoser()
        {
            if (Score1 < Score2) return Team1;
            if (Score2 < Score1) return Team2;
            return null;
        }
    }
}
