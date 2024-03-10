namespace Veran_Final_Summative
{
    partial class userFormEdits
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.changePassbut = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirm New Password:";
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(269, 12);
            this.pass1.Name = "pass1";
            this.pass1.PasswordChar = '*';
            this.pass1.Size = new System.Drawing.Size(287, 32);
            this.pass1.TabIndex = 5;
            // 
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(269, 61);
            this.newPass.Name = "newPass";
            this.newPass.PasswordChar = '*';
            this.newPass.Size = new System.Drawing.Size(287, 32);
            this.newPass.TabIndex = 6;
            // 
            // changePassbut
            // 
            this.changePassbut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePassbut.Location = new System.Drawing.Point(531, 117);
            this.changePassbut.Name = "changePassbut";
            this.changePassbut.Size = new System.Drawing.Size(200, 38);
            this.changePassbut.TabIndex = 7;
            this.changePassbut.Text = "Confirm";
            this.changePassbut.UseVisualStyleBackColor = true;
            this.changePassbut.Click += new System.EventHandler(this.changePassbut_Click);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.Location = new System.Drawing.Point(575, 39);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(144, 24);
            this.showPass.TabIndex = 8;
            this.showPass.Text = "Show Passwords";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // userFormEdits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 160);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.changePassbut);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userFormEdits";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Button changePassbut;
        private System.Windows.Forms.CheckBox showPass;
    }
}