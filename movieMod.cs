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
    public partial class movieMod : Form
    {
        DataAccess dt = new DataAccess();
        String selectedItem = null;
        public movieMod()
        {
            InitializeComponent();
            movieDgrid.ClearSelection();
            refDataTbl();
            movieDgrid.Columns[0].HeaderText = "Movie Name";
            movieDgrid.Columns[1].HeaderText = "Movie Genre";
            movieDgrid.Columns[2].HeaderText = "Rental Fee";
            movieDgrid.Sort(movieDgrid.Columns[0], ListSortDirection.Ascending);
        }
        public void refDataTbl()
        {
            movieDgrid.DataSource = dt.ViewAllRecord();
            movieDgrid.ClearSelection();
            selectedItem = null;
            movieDgrid.Sort(movieDgrid.Columns[0], ListSortDirection.Ascending);
        }

        private void mAINMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm showAdmins = new adminForm();
            showAdmins.ShowDialog();
            this.Close();
        }

        private void movieMod_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            movieAddForm showAddMovie = new movieAddForm();
            showAddMovie.ShowDialog();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refDataTbl();
            byName.Checked = false;
            byGenre.Checked = false;
            byRentalFee.Checked = false;
            txtSearch.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            movieEditForm.tobeEditedMovie = selectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Select a Record and Try Again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                movieEditForm showEditMovie = new movieEditForm();
                showEditMovie.ShowDialog();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedItem == null)
            {
                MessageBox.Show("Select a Record and Try Again!" ,"Error!",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else
            {
              DialogResult todelete = MessageBox.Show("Do You Want To Delete - ' " + selectedItem + "' ?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (todelete == DialogResult.Yes)
               {
                   dt.DeleteMovie(selectedItem);
                   MessageBox.Show("Movie: " + selectedItem + " has been Deleted", "Success");
                   refDataTbl();

               }
            }
            
        }

        private void movieDgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(movieDgrid.SelectedRows.Count > 0)
            {
                selectedItem = movieDgrid.SelectedCells[0].Value.ToString();
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Enter Something in The Search Bar");
            }
            else
            {
                if(byName.Checked == true)
                {           
                    movieDgrid.DataSource = dt.SearchByName(txtSearch.Text);
                }else if(byGenre.Checked == true){
                    movieDgrid.DataSource = dt.SearchbyGenre(txtSearch.Text);
                }
            }

            
        }
    }
}
