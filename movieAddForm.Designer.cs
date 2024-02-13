
namespace Veran_Final_Summative
{
    partial class movieAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movieAddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtRentalFee = new System.Windows.Forms.TextBox();
            this.cmboMovieGenre = new System.Windows.Forms.ComboBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Movie Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Movie Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add Rental Fee:";
            // 
            // txtAddName
            // 
            this.txtAddName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddName.Location = new System.Drawing.Point(174, 18);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(228, 28);
            this.txtAddName.TabIndex = 1;
            // 
            // txtRentalFee
            // 
            this.txtRentalFee.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentalFee.Location = new System.Drawing.Point(174, 111);
            this.txtRentalFee.Name = "txtRentalFee";
            this.txtRentalFee.ReadOnly = true;
            this.txtRentalFee.Size = new System.Drawing.Size(228, 28);
            this.txtRentalFee.TabIndex = 3;
            // 
            // cmboMovieGenre
            // 
            this.cmboMovieGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboMovieGenre.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmboMovieGenre.Location = new System.Drawing.Point(174, 68);
            this.cmboMovieGenre.Name = "cmboMovieGenre";
            this.cmboMovieGenre.Size = new System.Drawing.Size(228, 29);
            this.cmboMovieGenre.TabIndex = 2;
            this.cmboMovieGenre.SelectedIndexChanged += new System.EventHandler(this.cmboMovieGenre_SelectedIndexChanged);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(435, 105);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(128, 39);
            this.btnAddMovie.TabIndex = 4;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(435, 60);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 39);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // movieAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 161);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.cmboMovieGenre);
            this.Controls.Add(this.txtRentalFee);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "movieAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Movies - Admin Module - CoolFLix";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.movieAddForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtRentalFee;
        private System.Windows.Forms.ComboBox cmboMovieGenre;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnClear;
    }
}