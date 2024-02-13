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
    public partial class movieAddForm : Form
    {
        
        DataAccess dt = new DataAccess();
        public movieAddForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmboMovieGenre.SelectedIndex = -1;
            txtAddName.Clear();
            txtRentalFee.Clear();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddName.Text) || cmboMovieGenre.SelectedIndex == -1 || String.IsNullOrEmpty(txtRentalFee.Text))
            {
                MessageBox.Show("Input Something! ","Error");
            }
            else
            {
                string formMovieName = txtAddName.Text;
                string formMovieGenre = cmboMovieGenre.SelectedItem.ToString();
                decimal formRentalFee = Decimal.Parse(txtRentalFee.Text);

                dt.SaveNewMovie(formMovieName, formMovieGenre, formRentalFee);
                MessageBox.Show("Successfully Added:  \nName: " + formMovieName + "\nMovie Genre:" + formMovieGenre + "\nRental Fee:" + formRentalFee, "Success!");
                cmboMovieGenre.SelectedIndex = -1;
                txtAddName.Clear();
                txtRentalFee.Clear();
               
               
            }

        }


        private void cmboMovieGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmboMovieGenre.SelectedIndex == -1){
                txtRentalFee.Clear();
            }
            else if(cmboMovieGenre.SelectedItem.ToString() == "Action")
            {
                txtRentalFee.Text = "120";
            }else if(cmboMovieGenre.SelectedItem.ToString() == "Anime")
            {
                txtRentalFee.Text = "150";
            }else if(cmboMovieGenre.SelectedItem.ToString() == "Comedies")
            {
                txtRentalFee.Text = "130";
            }else if(cmboMovieGenre.SelectedItem.ToString() == "Children and Family")
            {
                txtRentalFee.Text = "150";
            }else if(cmboMovieGenre.SelectedItem.ToString() == "Documentaries")
            {
                txtRentalFee.Text = "120";
            }else if(cmboMovieGenre.SelectedItem.ToString() == "Dramas")
            {
                txtRentalFee.Text = "165";
            }else if(cmboMovieGenre.SelectedItem.ToString() == "Horror")
            {
                txtRentalFee.Text = "145";
            }else if(cmboMovieGenre.SelectedItem.ToString() == "Thrillers")
            {
                txtRentalFee.Text = "130";
            }else if(cmboMovieGenre.SelectedItem.ToString() == "Sci-Fi")
            {
                txtRentalFee.Text = "150";
            }
            
        }

        private void movieAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            MessageBox.Show("Press Refresh To Show Your Added Movie");
        }
    }
}
