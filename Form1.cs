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
    public partial class Form1 : Form
    {
        DataAccess dt = new DataAccess();   
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUser.Text)|| String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Enter Something!", "Error"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string getUname = txtUser.Text;
                string getPass = dt.EncryptData(txtPass.Text);
                if (dt.CheckAccount(getUname,getPass))
                {
                    if (dt.Usertype.Equals("user"))
                    {
                        this.Hide();
                        userForm showForms = new userForm(getUname);
                        this.Visible = false;
                        showForms.ShowDialog();

                    }
                    else if (dt.Usertype.Equals("admin"))
                    {
                        this.Hide();
                        adminForm showAd = new adminForm();
                        this.Visible = false;
                        showAd.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Enter Credentials Correctly!\n-You might have entered an incorrect spelling" +
                        " of your account/password\n" +
                        "-Your entered credentials is not in the database. " +
                        "Try Creating a New Account", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtUser.Clear();
                    txtPass.Clear();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            createAcct cAct = new createAcct();
            this.Visible = true;

            cAct.ShowDialog();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = showPass.Checked ? '\0' : '*';
        }
    }
}
