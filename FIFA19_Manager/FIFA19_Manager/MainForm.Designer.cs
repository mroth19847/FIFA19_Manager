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
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1380, 764);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMatch;
        private System.Windows.Forms.Button btCreate;
        private PositionBox tfLV;
        private System.Windows.Forms.Label label11;
        private PositionBox tfIVR;
        private System.Windows.Forms.Label lbIV2;
        private PositionBox tfIVL;
        private System.Windows.Forms.Label lbIV;
        private PositionBox tfGK;
        private System.Windows.Forms.Label lbGK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox tfClub;
        private System.Windows.Forms.TextBox tfNation;
        private System.Windows.Forms.TextBox tfName;
        private System.Windows.Forms.Label lbClub;
        private System.Windows.Forms.Label lbNation;
        private System.Windows.Forms.Label lbnam;
        private System.Windows.Forms.ListBox liPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox club;
        private System.Windows.Forms.Label lbOverall;
        private PositionBox tfZDM;
        private System.Windows.Forms.Label label2;
        private PositionBox tfZMR;
        private System.Windows.Forms.Label label3;
        private PositionBox tfZML;
        private System.Windows.Forms.Label label4;
        private PositionBox tfRV;
        private System.Windows.Forms.Label label5;
        private PositionBox tfST;
        private System.Windows.Forms.Label label12;
        private PositionBox tfRS;
        private System.Windows.Forms.Label label13;
        private PositionBox tfLS;
        private System.Windows.Forms.Label lbLS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNationality;
        private Panel PlayerPanel;
        private Label lbName;
    }
}

