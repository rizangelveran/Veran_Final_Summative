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
    public partial class createAcct : Form
    {
        DataAccess dt = new DataAccess();
        public createAcct()
        {
            InitializeComponent();
        }

        private void btnNewAcct_Click(object sender, EventArgs e)
        {
            string formFname = txtfname.Text;
            string formLname = txtlname.Text;
            string formUserN = txtuser.Text;
            string formPass = dt.EncryptData(txtpass.Text);

            if (String.IsNullOrEmpty(formFname)||String.IsNullOrEmpty(formLname)||String.IsNullOrEmpty(formUserN)||String.IsNullOrEmpty(formPass) || String.IsNullOrEmpty(txtage.Text))
            {
                MessageBox.Show("Fill Up All the Needed Credentials to Proceed", "Error");
                txtfname.Clear();
                txtlname.Clear();
                txtuser.Clear();
                txtpass.Clear();
                txtage.Clear();
            }
            else
            {
                int formAge = int.Parse(txtage.Text);
                if(formAge < 18)
                {
                    MessageBox.Show("Due to Existing Laws in your state\n" +
                        "Only those of 18 years of age or more are allowed to create an account", "Error"
                        ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtfname.Clear();
                    txtlname.Clear();
                    txtuser.Clear();
                    txtpass.Clear();
                    txtage.Clear();
                }
                else
                {
                    if (dt.CheckAccount(formUserN,formPass))
                    {
                        MessageBox.Show("There is already an Account using this Credential \nTry Again!", "Error");
                    }
                    else
                    {
                        dt.SaveNewAcct(formFname, formLname, formUserN, formPass, formAge);
                        MessageBox.Show("Welcome to CoolFLix! " +formFname, "Success");
                        txtfname.Clear();
                        txtlname.Clear();
                        txtuser.Clear();
                        txtpass.Clear();
                        txtage.Clear();
                    }
                }
            }
            
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = showPass.Checked ? '\0' : '*';
        }
    }
}
