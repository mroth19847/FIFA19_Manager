using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FIFA19_Manager
{
    public class Match
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public TextBox OutputBox { get; set; }

        /// <summary>
        /// The function simulates the match randomly (Nevertheless, the better team has the better chances!).
        /// </summary>
        public void Simulate()
        {
            OutputBox.Text = "The match has started.\n";
            Random r = new Random();
            int goalCountT1 = 0, goalCountT2 = 0;
            for(int i = 0; i < 10; i++)
            {
                int rInt = r.Next(0, 3);
                if(rInt == 0)
                {
                    Player scorer;
                    if (getScoringTeam() == Team1)
                    {
                        goalCountT1++;
                        scorer = getScorer(Team1);
                        OutputBox.AppendText(String.Format(Team1.Name + ": " + scorer.Name + " has scored. " + goalCountT1 + ":" + goalCountT2+"\n"));
                    }
                    else
                    {
                        goalCountT2++;
                        scorer = getScorer(Team2);
                        OutputBox.AppendText(String.Format(Team2.Name + ": " + scorer.Name + " has scored. " + goalCountT1 + ":" + goalCountT2 + "\n"));
                    }
                }
                Thread.Sleep(1000);
            }
            OutputBox.AppendText("The match has ended.");
        }

        /// <summary>
        /// Returns randomly the team which scores. The team with the higher score has the higher possibility
        /// to score.
        /// </summary>
        /// <returns></returns>
        private Team getScoringTeam()
        {
            Random r = new Random();
            int score1 = Team1.Score;
            int score2 = Team2.Score;
            int help = score1 + score2;
            int rInt = r.Next(0, help);
            if (rInt <= score1) return Team1;
            return Team2;
        }

        /// <summary>
        /// The function returns a reandom player of a given team, who is the scorer of a goal. The strikers have a 60% chance to score,
        /// the center players a 20%, the defenders a 19% chance and the goalkeepre a 1% chance.
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        private Player getScorer(Team team)
        {
            Random r = new Random();
            int rInt = r.Next(1, 100);
            //Striker: 60%
            //Center: 20%
            //Defense: 19%
            //GK: 1%
            if(rInt <= 60)
            {
                rInt = r.Next(0, 2);
                switch (rInt)
                {
                    case 0: return team.LS;
                    case 1: return team.ST;
                    case 2: return team.RS;
                }
            }
            else if (rInt <= 80)
            {
                rInt = r.Next(0, 2);
                switch (rInt)
                {
                    case 0: return team.ZML;
                    case 1: return team.ZMR;
                    case 2: return team.ZDM;
                }
            }
            else if (rInt <= 99)
            {
                rInt = r.Next(0, 3);
                switch (rInt)
                {
                    case 0: return team.LV;
                    case 1: return team.IVL;
                    case 2: return team.RV;
                    case 3: return team.IVR;
                }
            }
            return team.GK;
        }
    }
}
