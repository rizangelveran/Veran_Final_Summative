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
    public partial class movieEditForm : Form
    {
        DataAccess dt = new DataAccess();
        public static string tobeEditedMovie;
        public movieEditForm()
        {
            InitializeComponent();
            dt.CurrentMovieName = tobeEditedMovie;
            this.Text = "Edit: '" + dt.CurrentMovieName + "' - Admin Module - CoolFLix";
            dt.GetSelectedMovie(dt.CurrentMovieName);
            txtAddName.Text = dt.Moviename;
            cmboMovieGenre.Text = dt.Moviegenre;
           txtRentalFee.Text = dt.Rentalfee.ToString();
        }

        private void cmboMovieGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboMovieGenre.SelectedIndex == -1)
            {
                txtRentalFee.Clear();
            }
            else if (cmboMovieGenre.SelectedItem.ToString() == "Action")
            {
                txtRentalFee.Text = "120";
            }
            else if (cmboMovieGenre.SelectedItem.ToString() == "Anime")
            {
                txtRentalFee.Text = "150";
            }
            else if (cmboMovieGenre.SelectedItem.ToString() == "Comedies")
            {
                txtRentalFee.Text = "130";
            }
            else if (cmboMovieGenre.SelectedItem.ToString() == "Children and Family")
            {
                txtRentalFee.Text = "150";
            }
            else if (cmboMovieGenre.SelectedItem.ToString() == "Documentaries")
            {
                txtRentalFee.Text = "120";
            }
            else if (cmboMovieGenre.SelectedItem.ToString() == "Dramas")
            {
                txtRentalFee.Text = "165";
            }
            else if (cmboMovieGenre.SelectedItem.ToString() == "Horror")
            {
                txtRentalFee.Text = "145";
            }
            else if (cmboMovieGenre.SelectedItem.ToString() == "Thrillers")
            {
                txtRentalFee.Text = "130";
            }
            else if (cmboMovieGenre.SelectedItem.ToString() == "Sci-Fi")
            {
                txtRentalFee.Text = "150";
            }
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddName.Text) || cmboMovieGenre.SelectedIndex == -1 || cmboMovieGenre.Text == null || String.IsNullOrEmpty(txtRentalFee.Text))
            {
                MessageBox.Show("Input Something! ", "Error");
            }
            else
            {
                string formMovieName = txtAddName.Text;
                string formMovieGenre = cmboMovieGenre.SelectedItem.ToString();
                decimal formRentalFee = Decimal.Parse(txtRentalFee.Text);

                dt.EditMovie(dt.CurrentMovieName, formMovieName, formMovieGenre, formRentalFee);
                MessageBox.Show("Successfully Edited:  \nName: " + formMovieName + "\nMovie Genre:" + formMovieGenre + "\nRental Fee:" + formRentalFee, "Success!");
                cmboMovieGenre.SelectedIndex = -1;
                txtAddName.Clear();
                txtRentalFee.Clear();


            }
        }

        private void movieEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Press Refresh To Show Your Edited Movie!");
        }
    }
}
