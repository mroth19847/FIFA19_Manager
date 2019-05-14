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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tfTeam1 = new System.Windows.Forms.TextBox();
            this.tfTeam2 = new System.Windows.Forms.TextBox();
            this.lbVS = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.taOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // liTeams
            // 
            this.liTeams.FormattingEnabled = true;
            this.liTeams.ItemHeight = 25;
            this.liTeams.Location = new System.Drawing.Point(12, 12);
            this.liTeams.Name = "liTeams";
            this.liTeams.Size = new System.Drawing.Size(378, 679);
            this.liTeams.TabIndex = 0;
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
            this.panel1.Location = new System.Drawing.Point(396, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 678);
            this.panel1.TabIndex = 1;
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
            // tfTeam1
            // 
            this.tfTeam1.Location = new System.Drawing.Point(25, 80);
            this.tfTeam1.Multiline = true;
            this.tfTeam1.Name = "tfTeam1";
            this.tfTeam1.ReadOnly = true;
            this.tfTeam1.Size = new System.Drawing.Size(203, 38);
            this.tfTeam1.TabIndex = 2;
            // 
            // tfTeam2
            // 
            this.tfTeam2.Location = new System.Drawing.Point(496, 80);
            this.tfTeam2.Multiline = true;
            this.tfTeam2.Name = "tfTeam2";
            this.tfTeam2.ReadOnly = true;
            this.tfTeam2.Size = new System.Drawing.Size(203, 38);
            this.tfTeam2.TabIndex = 3;
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
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(265, 149);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(190, 56);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            // 
            // taOutput
            // 
            this.taOutput.Location = new System.Drawing.Point(158, 224);
            this.taOutput.Multiline = true;
            this.taOutput.Name = "taOutput";
            this.taOutput.Size = new System.Drawing.Size(411, 377);
            this.taOutput.TabIndex = 6;
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
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.ForeColor = System.Drawing.Color.White;
            this.lbResult.Location = new System.Drawing.Point(133, 638);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 25);
            this.lbResult.TabIndex = 8;
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 707);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.liTeams);
            this.Name = "MatchForm";
            this.Text = "Match Simulation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}