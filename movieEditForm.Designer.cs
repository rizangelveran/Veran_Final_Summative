
namespace Veran_Final_Summative
{
    partial class movieEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movieEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.cmboMovieGenre = new System.Windows.Forms.ComboBox();
            this.txtRentalFee = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Movie Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edit Movie Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edit Rental Fee:";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(177, 18);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(247, 28);
            this.txtAddName.TabIndex = 3;
            // 
            // cmboMovieGenre
            // 
            this.cmboMovieGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboMovieGenre.FormattingEnabled = true;
            this.cmboMovieGenre.Items.AddRange(new object[] {
            "Action",
            "Anime",
            "Comedies",
            "Children and Family",
            "Documentaries",
            "Dramas",
            "Horror",
            "Thrillers",
            "Sci-Fi"});
            this.cmboMovieGenre.Location = new System.Drawing.Point(177, 58);
            this.cmboMovieGenre.Name = "cmboMovieGenre";
            this.cmboMovieGenre.Size = new System.Drawing.Size(247, 29);
            this.cmboMovieGenre.TabIndex = 4;
            this.cmboMovieGenre.SelectedIndexChanged += new System.EventHandler(this.cmboMovieGenre_SelectedIndexChanged);
            // 
            // txtRentalFee
            // 
            this.txtRentalFee.Location = new System.Drawing.Point(177, 104);
            this.txtRentalFee.Name = "txtRentalFee";
            this.txtRentalFee.ReadOnly = true;
            this.txtRentalFee.Size = new System.Drawing.Size(247, 28);
            this.txtRentalFee.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(462, 111);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 47);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // movieEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 170);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtRentalFee);
            this.Controls.Add(this.cmboMovieGenre);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "movieEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Movies - Admin Module - CoolFLix";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.movieEditForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.ComboBox cmboMovieGenre;
        private System.Windows.Forms.TextBox txtRentalFee;
        private System.Windows.Forms.Button btnEdit;
    }
}