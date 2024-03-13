using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHelper;

namespace Veran_Final_Summative
{
    public partial class reportMod : Form
    {
        DataAccess dt = new DataAccess();

        public reportMod()
        {
            InitializeComponent();
            time2day.Text = DateTime.Now.ToString("hh:mm:ss tt");
            dmy2day.Text = DateTime.Now.ToShortDateString();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm showAdmins = new adminForm();
            showAdmins.ShowDialog();
            this.Close();
        }

        private void reportMod_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
