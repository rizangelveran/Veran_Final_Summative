using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veran_Final_Summative
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void adminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 logger = new Form1();
            logger.ShowDialog();
            logger.Visible = true;
            this.Close();
        }

        private void btnMoviemod_Click(object sender, EventArgs e)
        {
            this.Hide();
            movieMod showMovie = new movieMod();
            showMovie.ShowDialog();
            this.Close();
        }

        private void btnReportmod_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportMod showReport = new reportMod();
            showReport.ShowDialog();
            this.Close();
        }
    }
}
