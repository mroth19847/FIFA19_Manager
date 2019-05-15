using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace FIFA19_Manager
{
    public class Match : Form
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        private TextBox OutputBox;
        private PictureBox ImageBox;
        private Label lbTeam1;
        private Label lbTeam2;
        private Label lbScore;

        /// <summary>
        /// The loadForm() function loads and displays the form.
        /// </summary>
        private void loadForm()
        {
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.lbTeam1 = new System.Windows.Forms.Label();
            this.lbTeam2 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            //((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 375);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(587, 230);
            this.OutputBox.TabIndex = 0;
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(12, 106);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(586, 263);
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            // 
            // lbTeam1
            // 
            this.lbTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeam1.Location = new System.Drawing.Point(12, 32);
            this.lbTeam1.Name = "lbTeam1";
            this.lbTeam1.Size = new System.Drawing.Size(171, 46);
            this.lbTeam1.TabIndex = 2;
            this.lbTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTeam2
            // 
            this.lbTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeam2.Location = new System.Drawing.Point(428, 32);
            this.lbTeam2.Name = "lbTeam2";
            this.lbTeam2.Size = new System.Drawing.Size(171, 46);
            this.lbTeam2.TabIndex = 3;
            this.lbTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(213, 32);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(171, 46);
            this.lbScore.TabIndex = 4;
            this.lbScore.Text = "0 - 0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 617);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbTeam2);
            this.Controls.Add(this.lbTeam1);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.OutputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Match";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation";
            //((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        /// <summary>
        /// The function simulates the match randomly (Nevertheless, the better team has the better chances!).
        /// </summary>
        public void Simulate()
        {
            loadForm();
            this.Show();
            ImageBox.Image = Image.FromFile("./SimulationImages/Empty.png");
            OutputBox.Text = "The match has started.";
            lbTeam1.Text = Team1.Name;
            lbTeam2.Text = Team2.Name;
            Random r = new Random();
            int goalCountT1 = 0, goalCountT2 = 0;
            int side = 0;
            for (int i = 0; i < 20; i++)
            {
                if (i == 10)
                {
                    side = 1;
                    lbTeam1.Text = Team2.Name;
                    lbTeam2.Text = Team1.Name;
                    ImageBox.Image = Image.FromFile("./SimulationImages/Halftime.png");
                    refreshScoreBoard(side, goalCountT1, goalCountT2);
                    AppendLine("Halftime!");
                    Thread.Sleep(2000);
                }
                int rInt = r.Next(0, 8);
                if (rInt == 0)
                {
                    Player scorer;
                    if (getScoringTeam() == Team1)
                    {
                        goalCountT1++;
                        scorer = getScorer(Team1);
                        AppendLine(Team1.Name + ": " + scorer.Name + " has scored.");
                        rInt = r.Next(1, 3);
                        int h = side + 1;
                        ImageBox.Image = Image.FromFile("./SimulationImages/Goal" + h + "" + rInt + ".png");
                        refreshScoreBoard(side, goalCountT1, goalCountT2);
                        Thread.Sleep(1000);

                    }
                    else
                    {
                        goalCountT2++;
                        scorer = getScorer(Team2);
                        AppendLine(Team2.Name + ": " + scorer.Name + " has scored.");
                        rInt = r.Next(1, 3);
                        int h = 1 - side + 1;
                        ImageBox.Image = Image.FromFile("./SimulationImages/Goal" + h + "" + rInt + ".png");
                        refreshScoreBoard(side, goalCountT1, goalCountT2);
                        Thread.Sleep(1000);

                    }
                }
                Thread.Sleep(1000);
                ImageBox.Image = Image.FromFile("./SimulationImages/Empty.png");
            }
            AppendLine("The match has ended, the form will close in 3 seconds.");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Displays the current scores of the teams on lbScore. It also pays attention if the teams have already swapped sides.
        /// </summary>
        /// <param name="side"></param>
        /// <param name="score1"></param>
        /// <param name="score2"></param>
        private void refreshScoreBoard(int side, int score1, int score2)
        {
            if (side == 0)
            {
                lbScore.Text = score1 + " - " + score2;
            }
            else
            {
                lbScore.Text = score2 + " - " + score1;
            }
        }

        /// <summary>
        /// The function appends the text of the Outputbox with the given strings. The function is needed, because \n is not working
        /// when appending a line with the predefined function.
        /// </summary>
        /// <param name="str"></param>
        private void AppendLine(String str)
        {
            string pre = OutputBox.Text;
            pre += "\n" + str;
            OutputBox.Text = pre;
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
