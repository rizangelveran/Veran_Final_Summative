namespace Veran_Final_Summative
{
    partial class chkoutMod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chkoutMod));
            this.btnEXIT = new System.Windows.Forms.Label();
            this.txtReciept = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxPay = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEXIT
            // 
            this.btnEXIT.AutoSize = true;
            this.btnEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEXIT.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(12, 9);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(110, 31);
            this.btnEXIT.TabIndex = 0;
            this.btnEXIT.Text = "< BACK";
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // txtReciept
            // 
            this.txtReciept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReciept.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtReciept.Location = new System.Drawing.Point(18, 43);
            this.txtReciept.Name = "txtReciept";
            this.txtReciept.Size = new System.Drawing.Size(322, 397);
            this.txtReciept.TabIndex = 1;
            this.txtReciept.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payment:";
            // 
            // txtbxPay
            // 
            this.txtbxPay.Location = new System.Drawing.Point(363, 170);
            this.txtbxPay.Name = "txtbxPay";
            this.txtbxPay.Size = new System.Drawing.Size(264, 32);
            this.txtbxPay.TabIndex = 3;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(443, 235);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(124, 51);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // chkoutMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(667, 458);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtbxPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReciept);
            this.Controls.Add(this.btnEXIT);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "chkoutMod";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnEXIT;
        private System.Windows.Forms.RichTextBox txtReciept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxPay;
        private System.Windows.Forms.Button btnPay;
    }
}