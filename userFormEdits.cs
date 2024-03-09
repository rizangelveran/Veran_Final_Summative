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
    public partial class userFormEdits : Form
    {
        DataAccess dt = new DataAccess();
        String myUser;
        public userFormEdits(string getUsername)
        {
            InitializeComponent();
            myUser = getUsername;
            this.Text = "Change " + myUser + "'s Password";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
           //ignore
        }

        private void changePassbut_Click(object sender, EventArgs e)
        {
            if ((newPass.Text.Trim() == pass1.Text.Trim())&&(!String.IsNullOrEmpty(pass1.Text) || !String.IsNullOrEmpty(newPass.Text)))
            {
                string getNewPass = dt.EncryptData(newPass.Text);
               DialogResult des = MessageBox.Show("Do you want to change your Password?\nYou will be logged out in this session for your safety", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (des == DialogResult.Yes)
                {
                    dt.ChangeNewPass(myUser, getNewPass); 
                    Application.Exit();
                    Application.Restart();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Confirm that password is the same with each other", "Error Performing Action",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            newPass.PasswordChar = showPass.Checked ? '\0' : '*';
            pass1.PasswordChar = showPass.Checked ? '\0' : '*';
        }
    }
}
