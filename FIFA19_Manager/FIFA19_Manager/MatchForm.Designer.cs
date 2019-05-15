using System.Windows.Forms;

namespace FIFA19_Manager
{
    partial class MatchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.liTeams = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taOutput = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.lbVS = new System.Windows.Forms.Label();
            this.tfTeam2 = new System.Windows.Forms.TextBox();
            this.tfTeam1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tfName = new System.Windows.Forms.TextBox();
            this.tfScore = new System.Windows.Forms.TextBox();
            this.tfWon = new System.Windows.Forms.TextBox();
            this.tfLost = new System.Windows.Forms.TextBox();
            this.tfDraw = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // liTeams
            // 
            this.liTeams.FormattingEnabled = true;
            this.liTeams.ItemHeight = 25;
            this.liTeams.Location = new System.Drawing.Point(12, 12);
            this.liTeams.Name = "liTeams";
            this.liTeams.Size = new System.Drawing.Size(332, 679);
            this.liTeams.TabIndex = 0;
            this.liTeams.SelectedIndexChanged += new System.EventHandler(this.liTeams_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.lbResult);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.taOutput);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.lbVS);
            this.panel1.Controls.Add(this.tfTeam2);
            this.panel1.Controls.Add(this.tfTeam1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(696, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 678);
            this.panel1.TabIndex = 1;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.ForeColor = System.Drawing.Color.White;
            this.lbResult.Location = new System.Drawing.Point(133, 638);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 25);
            this.lbResult.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result:";
            // 
            // taOutput
            // 
            this.taOutput.Location = new System.Drawing.Point(158, 224);
            this.taOutput.Multiline = true;
            this.taOutput.Name = "taOutput";
            this.taOutput.Size = new System.Drawing.Size(411, 377);
            this.taOutput.TabIndex = 6;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(265, 149);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(190, 56);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbVS
            // 
            this.lbVS.AutoSize = true;
            this.lbVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVS.ForeColor = System.Drawing.Color.White;
            this.lbVS.Location = new System.Drawing.Point(311, 63);
            this.lbVS.Name = "lbVS";
            this.lbVS.Size = new System.Drawing.Size(90, 55);
            this.lbVS.TabIndex = 4;
            this.lbVS.Text = "VS";
            // 
            // tfTeam2
            // 
            this.tfTeam2.Location = new System.Drawing.Point(496, 80);
            this.tfTeam2.Multiline = true;
            this.tfTeam2.Name = "tfTeam2";
            this.tfTeam2.ReadOnly = true;
            this.tfTeam2.Size = new System.Drawing.Size(203, 38);
            this.tfTeam2.TabIndex = 3;
            this.tfTeam2.Enter += new System.EventHandler(this.tfTeam2_Enter);
            // 
            // tfTeam1
            // 
            this.tfTeam1.Location = new System.Drawing.Point(25, 80);
            this.tfTeam1.Multiline = true;
            this.tfTeam1.Name = "tfTeam1";
            this.tfTeam1.ReadOnly = true;
            this.tfTeam1.Size = new System.Drawing.Size(203, 38);
            this.tfTeam1.TabIndex = 2;
            this.tfTeam1.Enter += new System.EventHandler(this.tfTeam2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(559, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Won";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Draw";
            // 
            // tfName
            // 
            this.tfName.Location = new System.Drawing.Point(371, 217);
            this.tfName.Multiline = true;
            this.tfName.Name = "tfName";
            this.tfName.ReadOnly = true;
            this.tfName.Size = new System.Drawing.Size(284, 37);
            this.tfName.TabIndex = 7;
            // 
            // tfScore
            // 
            this.tfScore.Location = new System.Drawing.Point(371, 291);
            this.tfScore.Multiline = true;
            this.tfScore.Name = "tfScore";
            this.tfScore.ReadOnly = true;
            this.tfScore.Size = new System.Drawing.Size(284, 37);
            this.tfScore.TabIndex = 8;
            // 
            // tfWon
            // 
            this.tfWon.Location = new System.Drawing.Point(371, 363);
            this.tfWon.Multiline = true;
            this.tfWon.Name = "tfWon";
            this.tfWon.ReadOnly = true;
            this.tfWon.Size = new System.Drawing.Size(284, 37);
            this.tfWon.TabIndex = 9;
            // 
            // tfLost
            // 
            this.tfLost.Location = new System.Drawing.Point(371, 428);
            this.tfLost.Multiline = true;
            this.tfLost.Name = "tfLost";
            this.tfLost.ReadOnly = true;
            this.tfLost.Size = new System.Drawing.Size(284, 37);
            this.tfLost.TabIndex = 10;
            // 
            // tfDraw
            // 
            this.tfDraw.Location = new System.Drawing.Point(371, 503);
            this.tfDraw.Multiline = true;
            this.tfDraw.Name = "tfDraw";
            this.tfDraw.ReadOnly = true;
            this.tfDraw.Size = new System.Drawing.Size(284, 37);
            this.tfDraw.TabIndex = 11;
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 707);
            this.Controls.Add(this.tfDraw);
            this.Controls.Add(this.tfLost);
            this.Controls.Add(this.tfWon);
            this.Controls.Add(this.tfScore);
            this.Controls.Add(this.tfName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.liTeams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match Simulation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liTeams;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taOutput;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbVS;
        private System.Windows.Forms.TextBox tfTeam2;
        private System.Windows.Forms.TextBox tfTeam1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tfName;
        private System.Windows.Forms.TextBox tfScore;
        private System.Windows.Forms.TextBox tfWon;
        private System.Windows.Forms.TextBox tfLost;
        private System.Windows.Forms.TextBox tfDraw;
    }
}