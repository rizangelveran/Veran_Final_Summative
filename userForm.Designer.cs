
namespace Veran_Final_Summative
{
    partial class userForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCurrentRentedMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.showName = new System.Windows.Forms.Label();
            this.movieDgrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsearchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboSelGenre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.Button();
            this.cmboRentDur = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMovgenre = new System.Windows.Forms.TextBox();
            this.txtMovName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDgrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountOptionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1151, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountOptionsToolStripMenuItem
            // 
            this.accountOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAccountToolStripMenuItem,
            this.viewCurrentRentedMoviesToolStripMenuItem,
            this.lOGOUTToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.accountOptionsToolStripMenuItem.Name = "accountOptionsToolStripMenuItem";
            this.accountOptionsToolStripMenuItem.Size = new System.Drawing.Size(173, 32);
            this.accountOptionsToolStripMenuItem.Text = "Account Options";
            // 
            // editAccountToolStripMenuItem
            // 
            this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
            this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(343, 32);
            this.editAccountToolStripMenuItem.Text = "Edit Account";
            this.editAccountToolStripMenuItem.Click += new System.EventHandler(this.editAccountToolStripMenuItem_Click);
            // 
            // viewCurrentRentedMoviesToolStripMenuItem
            // 
            this.viewCurrentRentedMoviesToolStripMenuItem.Name = "viewCurrentRentedMoviesToolStripMenuItem";
            this.viewCurrentRentedMoviesToolStripMenuItem.Size = new System.Drawing.Size(343, 32);
            this.viewCurrentRentedMoviesToolStripMenuItem.Text = "View Current Rented Movies";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(343, 32);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(343, 32);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(67, 32);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(917, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello!";
            // 
            // showName
            // 
            this.showName.AutoSize = true;
            this.showName.BackColor = System.Drawing.Color.Tan;
            this.showName.Location = new System.Drawing.Point(981, 10);
            this.showName.Name = "showName";
            this.showName.Size = new System.Drawing.Size(27, 25);
            this.showName.TabIndex = 2;
            this.showName.Text = "...";
            // 
            // movieDgrid
            // 
            this.movieDgrid.AllowUserToAddRows = false;
            this.movieDgrid.AllowUserToDeleteRows = false;
            this.movieDgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.movieDgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDgrid.Location = new System.Drawing.Point(12, 70);
            this.movieDgrid.Name = "movieDgrid";
            this.movieDgrid.ReadOnly = true;
            this.movieDgrid.RowHeadersWidth = 51;
            this.movieDgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movieDgrid.Size = new System.Drawing.Size(629, 433);
            this.movieDgrid.TabIndex = 3;
            this.movieDgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movieDgrid_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search:";
            // 
            // txtsearchBox
            // 
            this.txtsearchBox.Location = new System.Drawing.Point(95, 38);
            this.txtsearchBox.Name = "txtsearchBox";
            this.txtsearchBox.Size = new System.Drawing.Size(216, 33);
            this.txtsearchBox.TabIndex = 5;
            this.txtsearchBox.TextChanged += new System.EventHandler(this.txtsearchBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Genre:";
            // 
            // cmboSelGenre
            // 
            this.cmboSelGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboSelGenre.FormattingEnabled = true;
            this.cmboSelGenre.Items.AddRange(new object[] {
            "All",
            "Action",
            "Anime",
            "Comedies",
            "Children and Family",
            "Documentaries",
            "Dramas",
            "Horror",
            "Thrillers",
            "Sci-Fi"});
            this.cmboSelGenre.Location = new System.Drawing.Point(463, 35);
            this.cmboSelGenre.Name = "cmboSelGenre";
            this.cmboSelGenre.Size = new System.Drawing.Size(197, 33);
            this.cmboSelGenre.TabIndex = 7;
            this.cmboSelGenre.SelectedIndexChanged += new System.EventHandler(this.cmboSelGenre_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClear);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPayment);
            this.groupBox1.Controls.Add(this.cmboRentDur);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtMovgenre);
            this.groupBox1.Controls.Add(this.txtMovName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(666, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 449);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Your Movies";
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(392, 16);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(75, 35);
            this.txtClear.TabIndex = 10;
            this.txtClear.Text = "Clear";
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Day";
            // 
            // txtPayment
            // 
            this.txtPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPayment.Location = new System.Drawing.Point(144, 362);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(198, 44);
            this.txtPayment.TabIndex = 8;
            this.txtPayment.Text = "Go To Payment";
            this.txtPayment.UseVisualStyleBackColor = true;
            this.txtPayment.Click += new System.EventHandler(this.txtPayment_Click);
            // 
            // cmboRentDur
            // 
            this.cmboRentDur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboRentDur.FormattingEnabled = true;
            this.cmboRentDur.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmboRentDur.Location = new System.Drawing.Point(220, 269);
            this.cmboRentDur.Name = "cmboRentDur";
            this.cmboRentDur.Size = new System.Drawing.Size(149, 33);
            this.cmboRentDur.TabIndex = 7;
            this.cmboRentDur.SelectedIndexChanged += new System.EventHandler(this.cmboRentDur_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Renting Duration for";
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPrice.Location = new System.Drawing.Point(79, 220);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(355, 33);
            this.txtPrice.TabIndex = 5;
            // 
            // txtMovgenre
            // 
            this.txtMovgenre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMovgenre.Location = new System.Drawing.Point(79, 156);
            this.txtMovgenre.Name = "txtMovgenre";
            this.txtMovgenre.ReadOnly = true;
            this.txtMovgenre.Size = new System.Drawing.Size(355, 33);
            this.txtMovgenre.TabIndex = 4;
            // 
            // txtMovName
            // 
            this.txtMovName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMovName.Location = new System.Drawing.Point(79, 84);
            this.txtMovName.Name = "txtMovName";
            this.txtMovName.ReadOnly = true;
            this.txtMovName.Size = new System.Drawing.Size(355, 33);
            this.txtMovName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Movie Name";
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1151, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmboSelGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.movieDgrid);
            this.Controls.Add(this.showName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "userForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to CoolFlix";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDgrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCurrentRentedMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label showName;
        private System.Windows.Forms.DataGridView movieDgrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsearchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboSelGenre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtPayment;
        private System.Windows.Forms.ComboBox cmboRentDur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMovgenre;
        private System.Windows.Forms.TextBox txtMovName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button txtClear;
    }
}