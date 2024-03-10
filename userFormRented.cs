﻿using System;
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
    public partial class userFormRented : Form
    {
        DataAccess dt = new DataAccess();
        String myUser;

        public userFormRented(string getUsername)
        {
            InitializeComponent();
            myUser = getUsername;
            this.Text = "" + myUser + "'s Rented Movies";
            refDataTbl();
            rentedMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//fill data in column
            rentedMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rentedMovies.Columns[0].HeaderText = "Movie Name";
            rentedMovies.Columns[1].HeaderText = "Movie Genre";
            rentedMovies.Columns[2].HeaderText = "Total Payment";
            rentedMovies.Columns[3].HeaderText = "Change";
            rentedMovies.Columns[4].HeaderText = "Purchased by";
            rentedMovies.Columns[5].HeaderText = "Duration";
            rentedMovies.Columns[6].HeaderText = "Year";
  
        }
        public void refDataTbl()
        {
            rentedMovies.DataSource = dt.GetRentedMovie(myUser);
            rentedMovies.ClearSelection();
            rentedMovies.Sort(rentedMovies.Columns[0], ListSortDirection.Ascending);
            rentedMovies.ClearSelection();

        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where your rented movies show\nUse Search to find movies", "Info");
        }

        private void rentedMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userFormRented_Load(object sender, EventArgs e)
        {
            refDataTbl();
            rentedMovies.Update();
            rentedMovies.Refresh();
        }
    }
}