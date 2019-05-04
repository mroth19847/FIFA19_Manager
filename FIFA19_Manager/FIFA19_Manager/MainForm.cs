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
    public partial class MainForm : Form
    {

        private PlayerBL bl;

        public MainForm()
        {
            InitializeComponent();
            bl = new PlayerBL(liPlayer);
            try
            {
                bl.load();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n"+ex.StackTrace);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void btMatch_Click(object sender, EventArgs e)
        {

        }

        private void btCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
