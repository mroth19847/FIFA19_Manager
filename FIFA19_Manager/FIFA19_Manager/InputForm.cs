using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA19_Manager
{
    public partial class InputForm : Form
    {
        private MainForm form;

        public InputForm(MainForm form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tfName.Text.Length < 5 || tfName.Text.Length > 30)
            {
                form.TeamName = tfName.Text;
            }
            else
            {
                MessageBox.Show("The text has to be between 5 and 30 letters long.");
            }
            this.Dispose();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
