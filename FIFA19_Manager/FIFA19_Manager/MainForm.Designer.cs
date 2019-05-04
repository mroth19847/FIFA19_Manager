using System.Windows.Forms;

namespace FIFA19_Manager
{
    partial class MainForm
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
            this.btMatch = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.tfLV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tfIVR = new System.Windows.Forms.TextBox();
            this.lbIV2 = new System.Windows.Forms.Label();
            this.tfIVL = new System.Windows.Forms.TextBox();
            this.lbIV = new System.Windows.Forms.Label();
            this.tfGK = new System.Windows.Forms.TextBox();
            this.lbGK = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.tfClub = new System.Windows.Forms.TextBox();
            this.tfNation = new System.Windows.Forms.TextBox();
            this.tfName = new System.Windows.Forms.TextBox();
            this.lbClub = new System.Windows.Forms.Label();
            this.lbNation = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.liPlayer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nation = new System.Windows.Forms.PictureBox();
            this.lbOverall = new System.Windows.Forms.Label();
            this.tfZDM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tfZMR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tfZML = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tfRV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tfST = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tfRS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tfLS = new System.Windows.Forms.TextBox();
            this.lbLS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNationality = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btMatch
            // 
            this.btMatch.Location = new System.Drawing.Point(1466, 865);
            this.btMatch.Name = "btMatch";
            this.btMatch.Size = new System.Drawing.Size(188, 79);
            this.btMatch.TabIndex = 47;
            this.btMatch.Text = "Match =>";
            this.btMatch.UseVisualStyleBackColor = true;
            this.btMatch.Click += new System.EventHandler(this.btMatch_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(1113, 865);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(225, 79);
            this.btCreate.TabIndex = 46;
            this.btCreate.Text = "Create Team";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // tfLV
            // 
            this.tfLV.Location = new System.Drawing.Point(20, 485);
            this.tfLV.Multiline = true;
            this.tfLV.Name = "tfLV";
            this.tfLV.ReadOnly = true;
            this.tfLV.Size = new System.Drawing.Size(225, 34);
            this.tfLV.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(105, 457);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 25);
            this.label11.TabIndex = 43;
            this.label11.Text = "LV";
            // 
            // tfIVR
            // 
            this.tfIVR.Location = new System.Drawing.Point(429, 526);
            this.tfIVR.Multiline = true;
            this.tfIVR.Name = "tfIVR";
            this.tfIVR.ReadOnly = true;
            this.tfIVR.Size = new System.Drawing.Size(225, 34);
            this.tfIVR.TabIndex = 42;
            // 
            // lbIV2
            // 
            this.lbIV2.AutoSize = true;
            this.lbIV2.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbIV2.Location = new System.Drawing.Point(530, 494);
            this.lbIV2.Name = "lbIV2";
            this.lbIV2.Size = new System.Drawing.Size(31, 25);
            this.lbIV2.TabIndex = 41;
            this.lbIV2.Text = "IV";
            // 
            // tfIVL
            // 
            this.tfIVL.Location = new System.Drawing.Point(197, 526);
            this.tfIVL.Multiline = true;
            this.tfIVL.Name = "tfIVL";
            this.tfIVL.ReadOnly = true;
            this.tfIVL.Size = new System.Drawing.Size(225, 34);
            this.tfIVL.TabIndex = 40;
            // 
            // lbIV
            // 
            this.lbIV.AutoSize = true;
            this.lbIV.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbIV.Location = new System.Drawing.Point(291, 494);
            this.lbIV.Name = "lbIV";
            this.lbIV.Size = new System.Drawing.Size(31, 25);
            this.lbIV.TabIndex = 39;
            this.lbIV.Text = "IV";
            // 
            // tfGK
            // 
            this.tfGK.Location = new System.Drawing.Point(307, 631);
            this.tfGK.Multiline = true;
            this.tfGK.Name = "tfGK";
            this.tfGK.ReadOnly = true;
            this.tfGK.Size = new System.Drawing.Size(225, 34);
            this.tfGK.TabIndex = 38;
            // 
            // lbGK
            // 
            this.lbGK.AutoSize = true;
            this.lbGK.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbGK.Location = new System.Drawing.Point(392, 603);
            this.lbGK.Name = "lbGK";
            this.lbGK.Size = new System.Drawing.Size(42, 25);
            this.lbGK.TabIndex = 37;
            this.lbGK.Text = "GK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1185, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 42);
            this.label7.TabIndex = 36;
            this.label7.Text = "Team";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(531, 766);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(204, 79);
            this.btAdd.TabIndex = 35;
            this.btAdd.Text = "Add =>";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Picture";
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(531, 350);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(204, 198);
            this.picture.TabIndex = 33;
            this.picture.TabStop = false;
            // 
            // tfClub
            // 
            this.tfClub.Location = new System.Drawing.Point(135, 237);
            this.tfClub.Name = "tfClub";
            this.tfClub.Size = new System.Drawing.Size(344, 31);
            this.tfClub.TabIndex = 31;
            // 
            // tfNation
            // 
            this.tfNation.Location = new System.Drawing.Point(135, 174);
            this.tfNation.Name = "tfNation";
            this.tfNation.Size = new System.Drawing.Size(344, 31);
            this.tfNation.TabIndex = 30;
            // 
            // tfName
            // 
            this.tfName.Location = new System.Drawing.Point(135, 106);
            this.tfName.Name = "tfName";
            this.tfName.Size = new System.Drawing.Size(344, 31);
            this.tfName.TabIndex = 29;
            // 
            // lbClub
            // 
            this.lbClub.AutoSize = true;
            this.lbClub.Location = new System.Drawing.Point(42, 240);
            this.lbClub.Name = "lbClub";
            this.lbClub.Size = new System.Drawing.Size(56, 25);
            this.lbClub.TabIndex = 28;
            this.lbClub.Text = "Club";
            // 
            // lbNation
            // 
            this.lbNation.AutoSize = true;
            this.lbNation.Location = new System.Drawing.Point(24, 177);
            this.lbNation.Name = "lbNation";
            this.lbNation.Size = new System.Drawing.Size(74, 25);
            this.lbNation.TabIndex = 27;
            this.lbNation.Text = "Nation";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(42, 109);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 25);
            this.lbName.TabIndex = 26;
            this.lbName.Text = "Name";
            // 
            // liPlayer
            // 
            this.liPlayer.FormattingEnabled = true;
            this.liPlayer.ItemHeight = 25;
            this.liPlayer.Location = new System.Drawing.Point(29, 316);
            this.liPlayer.Name = "liPlayer";
            this.liPlayer.Size = new System.Drawing.Size(441, 529);
            this.liPlayer.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 42);
            this.label1.TabIndex = 24;
            this.label1.Text = "Player";
            // 
            // nation
            // 
            this.nation.Location = new System.Drawing.Point(560, 554);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(139, 112);
            this.nation.TabIndex = 48;
            this.nation.TabStop = false;
            // 
            // lbOverall
            // 
            this.lbOverall.Location = new System.Drawing.Point(511, 723);
            this.lbOverall.Name = "lbOverall";
            this.lbOverall.Size = new System.Drawing.Size(250, 40);
            this.lbOverall.TabIndex = 49;
            // 
            // tfZDM
            // 
            this.tfZDM.Location = new System.Drawing.Point(307, 384);
            this.tfZDM.Multiline = true;
            this.tfZDM.Name = "tfZDM";
            this.tfZDM.ReadOnly = true;
            this.tfZDM.Size = new System.Drawing.Size(225, 34);
            this.tfZDM.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(392, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "ZDM";
            // 
            // tfZMR
            // 
            this.tfZMR.Location = new System.Drawing.Point(493, 286);
            this.tfZMR.Multiline = true;
            this.tfZMR.Name = "tfZMR";
            this.tfZMR.ReadOnly = true;
            this.tfZMR.Size = new System.Drawing.Size(225, 34);
            this.tfZMR.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(586, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "ZM";
            // 
            // tfZML
            // 
            this.tfZML.Location = new System.Drawing.Point(129, 286);
            this.tfZML.Multiline = true;
            this.tfZML.Name = "tfZML";
            this.tfZML.ReadOnly = true;
            this.tfZML.Size = new System.Drawing.Size(225, 34);
            this.tfZML.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(223, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "ZM";
            // 
            // tfRV
            // 
            this.tfRV.Location = new System.Drawing.Point(601, 486);
            this.tfRV.Multiline = true;
            this.tfRV.Name = "tfRV";
            this.tfRV.ReadOnly = true;
            this.tfRV.Size = new System.Drawing.Size(225, 34);
            this.tfRV.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(705, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "RV";
            // 
            // tfST
            // 
            this.tfST.Location = new System.Drawing.Point(307, 108);
            this.tfST.Multiline = true;
            this.tfST.Name = "tfST";
            this.tfST.ReadOnly = true;
            this.tfST.Size = new System.Drawing.Size(225, 34);
            this.tfST.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.AliceBlue;
            this.label12.Location = new System.Drawing.Point(411, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 25);
            this.label12.TabIndex = 62;
            this.label12.Text = "ST";
            // 
            // tfRS
            // 
            this.tfRS.Location = new System.Drawing.Point(554, 148);
            this.tfRS.Multiline = true;
            this.tfRS.Name = "tfRS";
            this.tfRS.ReadOnly = true;
            this.tfRS.Size = new System.Drawing.Size(225, 34);
            this.tfRS.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.AliceBlue;
            this.label13.Location = new System.Drawing.Point(655, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 25);
            this.label13.TabIndex = 60;
            this.label13.Text = "RS";
            // 
            // tfLS
            // 
            this.tfLS.Location = new System.Drawing.Point(55, 139);
            this.tfLS.Multiline = true;
            this.tfLS.Name = "tfLS";
            this.tfLS.ReadOnly = true;
            this.tfLS.Size = new System.Drawing.Size(225, 34);
            this.tfLS.TabIndex = 59;
            // 
            // lbLS
            // 
            this.lbLS.AutoSize = true;
            this.lbLS.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbLS.Location = new System.Drawing.Point(152, 108);
            this.lbLS.Name = "lbLS";
            this.lbLS.Size = new System.Drawing.Size(38, 25);
            this.lbLS.TabIndex = 58;
            this.lbLS.Text = "LS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.tfRV);
            this.panel1.Controls.Add(this.tfST);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbGK);
            this.panel1.Controls.Add(this.tfRS);
            this.panel1.Controls.Add(this.tfGK);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lbIV);
            this.panel1.Controls.Add(this.tfLS);
            this.panel1.Controls.Add(this.tfIVL);
            this.panel1.Controls.Add(this.lbLS);
            this.panel1.Controls.Add(this.lbIV2);
            this.panel1.Controls.Add(this.tfZDM);
            this.panel1.Controls.Add(this.tfIVR);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tfZMR);
            this.panel1.Controls.Add(this.tfLV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tfZML);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(806, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 739);
            this.panel1.TabIndex = 64;
            // 
            // lbNationality
            // 
            this.lbNationality.Location = new System.Drawing.Point(511, 673);
            this.lbNationality.Name = "lbNationality";
            this.lbNationality.Size = new System.Drawing.Size(250, 40);
            this.lbNationality.TabIndex = 65;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1004);
            this.Controls.Add(this.lbNationality);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbOverall);
            this.Controls.Add(this.nation);
            this.Controls.Add(this.btMatch);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.tfClub);
            this.Controls.Add(this.tfNation);
            this.Controls.Add(this.tfName);
            this.Controls.Add(this.lbClub);
            this.Controls.Add(this.lbNation);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.liPlayer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIFA 19 Manager";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Width = 853;
            this.Height = 538;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        private System.Windows.Forms.Button btMatch;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.TextBox tfLV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tfIVR;
        private System.Windows.Forms.Label lbIV2;
        private System.Windows.Forms.TextBox tfIVL;
        private System.Windows.Forms.Label lbIV;
        private System.Windows.Forms.TextBox tfGK;
        private System.Windows.Forms.Label lbGK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox tfClub;
        private System.Windows.Forms.TextBox tfNation;
        private System.Windows.Forms.TextBox tfName;
        private System.Windows.Forms.Label lbClub;
        private System.Windows.Forms.Label lbNation;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ListBox liPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox nation;
        private System.Windows.Forms.Label lbOverall;
        private System.Windows.Forms.TextBox tfZDM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tfZMR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tfZML;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tfRV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tfST;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tfRS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tfLS;
        private System.Windows.Forms.Label lbLS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNationality;
    }
}

