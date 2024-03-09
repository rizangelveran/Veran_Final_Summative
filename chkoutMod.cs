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
    public partial class chkoutMod : Form
    {
        DataAccess dt = new DataAccess();
        String myUser, movName, movGenre;
        Decimal totPrice = 0;
        Decimal renFee, RentDuration;

      

        public chkoutMod(String getUser, String getMovName, String getMovGenre, Decimal getRenfee, Decimal getDuration)
        {
            InitializeComponent();
            myUser = getUser;
            movName = getMovName;
            movGenre = getMovGenre;
            renFee = getRenfee;
            RentDuration = getDuration;
            genReceipt();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Hide();
            userForm showForms = new userForm(myUser);
            this.Visible = false;
            showForms.ShowDialog();
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrEmpty(txtbxPay.Text))
            {
                MessageBox.Show("Please Enter an Amount to Pay", "Error");
            }
            else
            {
                Decimal enteredPayment = Decimal.Parse(txtbxPay.Text);
                
                
                    Decimal tobePaid = 0;
                    tobePaid = enteredPayment - totPrice;
                    if(enteredPayment >= totPrice)
                    {
                        
                        txtReciept.AppendText("\n========================");
                        txtReciept.AppendText("\n Payment Successfull");
                        txtReciept.AppendText("\n Change: " +tobePaid);
                        MessageBox.Show("Payment Successfull", "Success");
                        this.Hide();
                        userForm showForms = new userForm(myUser);
                        this.Visible = false;
                        showForms.ShowDialog();

                        dt.SaveMovieSale(movName, movGenre, enteredPayment,tobePaid, RentDuration, myUser);
                    
                    }
                    else
                    {
                        MessageBox.Show("Please Pay with the exact amount!", "Warn");

                    } 
                
            }
            
        }
        public void genReceipt()
        {
            txtReciept.ReadOnly = true;
            txtReciept.Text = "======================================";
            txtReciept.AppendText("\n Transaction Summary" );
            txtReciept.AppendText("\n Movie Name:  " +movName);
            txtReciept.AppendText("\n Movie Genre: " +movGenre);
            txtReciept.AppendText("\n \n\n\n\n\n");
            txtReciept.AppendText("\n Rental Fee:  " +renFee);
            txtReciept.AppendText("\n Rental Duration: " +RentDuration);
            totPrice = dt.PaymentCal(RentDuration,renFee);
            txtReciept.AppendText("\n Total Fee:  " + totPrice);
        }

    }
}
