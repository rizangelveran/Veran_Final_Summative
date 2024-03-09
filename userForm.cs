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
    public partial class userForm : Form
    {
        DataAccess dt = new DataAccess();
        String selectedItem = null;
        String myUser;
        public userForm(string name)
        {
            InitializeComponent();
            refDataTbl();
            myUser = name;
            showName.Text = myUser;
            movieDgrid.Columns[0].HeaderText = "Movie Name";
            movieDgrid.Columns[1].HeaderText = "Movie Genre";
            movieDgrid.Columns[2].HeaderText = "Rental Fee";
   
        }

        private void cmboSelGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmboSelGenre.SelectedIndex == 0)
            {
                refDataTbl();
            }
            else if (cmboSelGenre.SelectedItem.ToString() == "Action")
            {
                movieDgrid.DataSource = dt.SearchbyGenre(cmboSelGenre.SelectedItem.ToString());
            }
            else if (cmboSelGenre.SelectedItem.ToString() == "Anime")
            {
                movieDgrid.DataSource = dt.SearchbyGenre(cmboSelGenre.SelectedItem.ToString());
            }
            else if (cmboSelGenre.SelectedItem.ToString() == "Comedies")
            {
                movieDgrid.DataSource = dt.SearchbyGenre(cmboSelGenre.SelectedItem.ToString());
            }
            else if (cmboSelGenre.SelectedItem.ToString() == "Children and Family")
            {
                movieDgrid.DataSource = dt.SearchbyGenre(cmboSelGenre.SelectedItem.ToString());
            }
            else if (cmboSelGenre.SelectedItem.ToString() == "Documentaries")
            {
                movieDgrid.DataSource = dt.SearchbyGenre(cmboSelGenre.SelectedItem.ToString());
            }
            else if (cmboSelGenre.SelectedItem.ToString() == "Dramas")
            {
                movieDgrid.DataSource = dt.SearchbyGenre(cmboSelGenre.SelectedItem.ToString());
            }
            else if (cmboSelGenre.SelectedItem.ToString() == "Horror")
            {
                movieDgrid.DataSource = dt.SearchbyGenre(cmboSelGenre.SelectedItem.ToString());
            }
            else if (cmboSelGenre.SelectedItem.ToString() == "Thrillers")
            {
                movieDgrid.DataSource = dt.SearchbyGenre(cmboSelGenre.SelectedItem.ToString());
            }
            else if (cmboSelGenre.SelectedItem.ToString() == "Sci-Fi")
            {
                movieDgrid.DataSource = dt.SearchbyGenre(cmboSelGenre.SelectedItem.ToString());
            }


        }

        public void refDataTbl()
        {
            movieDgrid.DataSource = dt.ViewAllRecord();
            movieDgrid.ClearSelection();
            selectedItem = null;
            movieDgrid.Sort(movieDgrid.Columns[0], ListSortDirection.Ascending);
            cmboSelGenre.SelectedIndex = 0;
        }

        private void userForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String message = "Dear " + myUser + ",\nFirst Select a Movie by Searching it or Selecting a Genre" +
                "\nSelect Duration of your Rented Period\nThen You're Done!";
            MessageBox.Show(message,"How To Operate our Program!");
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmboRentDur_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = cmboRentDur.SelectedIndex;
            if(x > 1)
            {
                label8.Text = "Days";
            }
            else
            {
                label8.Text = "Day";
            }
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 logger = new Form1();
            logger.ShowDialog();
            logger.Visible = true;
            this.Close();
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userFormEdits editPass = new userFormEdits(myUser);
            editPass.ShowDialog();

        }

        private void txtsearchBox_TextChanged(object sender, EventArgs e)
        {
            movieDgrid.DataSource = dt.SearchByName(txtsearchBox.Text);
            if(String.IsNullOrEmpty(txtsearchBox.Text) && cmboSelGenre.SelectedIndex > -1)
            {
                cmboSelGenre.SelectedIndex = 0;
                refDataTbl();
                
            }

            if (movieDgrid.Rows.Count == 0)
            {
                MessageBox.Show("We Dont Have that Movie Yet (┬┬﹏┬┬)\nWe are updating our Movies List Don't Worry! ^o^☝️", "Not Found");
                txtsearchBox.Clear();
            }
        }

        private void movieDgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (movieDgrid.SelectedRows.Count > 0)
            {
                selectedItem = movieDgrid.SelectedCells[0].Value.ToString();
                dt.CurrentMovieName = selectedItem;
                dt.GetSelectedMovie(dt.CurrentMovieName);
                txtMovName.Text = dt.Moviename;
                txtMovgenre.Text = dt.Moviegenre;
                txtPrice.Text = dt.Rentalfee.ToString();
            }
            
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            cmboSelGenre.SelectedIndex = 0;
            txtsearchBox.Clear();
            refDataTbl();
            selectedItem = null;
            cmboRentDur.SelectedIndex = -1;
            txtMovName.Clear();
            txtMovgenre.Clear();
            txtPrice.Clear();
        }

        private void txtPayment_Click(object sender, EventArgs e)
        {
            if(selectedItem == null)
            {
                MessageBox.Show("Please Select Something Before Proceeding to Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if(cmboRentDur.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select your Renting Duration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Decimal durConvert = Convert.ToDecimal(cmboRentDur.SelectedItem.ToString());
                this.Hide();
                chkoutMod showCheckOutMod = new chkoutMod(myUser, txtMovName.Text, txtMovgenre.Text, Decimal.Parse(txtPrice.Text), durConvert);
                this.Visible = false;
                showCheckOutMod.ShowDialog();
            }
        }

        
    }
}
