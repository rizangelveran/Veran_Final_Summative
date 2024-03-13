namespace Veran_Final_Summative
{
    partial class userFormRented
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rentedMovies = new System.Windows.Forms.DataGridView();
            this.help = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.refreshBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // rentedMovies
            // 
            this.rentedMovies.AllowUserToAddRows = false;
            this.rentedMovies.AllowUserToDeleteRows = false;
            this.rentedMovies.AllowUserToResizeColumns = false;
            this.rentedMovies.AllowUserToResizeRows = false;
            this.rentedMovies.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.rentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentedMovies.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentedMovies.DefaultCellStyle = dataGridViewCellStyle4;
            this.rentedMovies.Location = new System.Drawing.Point(12, 62);
            this.rentedMovies.MultiSelect = false;
            this.rentedMovies.Name = "rentedMovies";
            this.rentedMovies.ReadOnly = true;
            this.rentedMovies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.rentedMovies.RowTemplate.Height = 24;
            this.rentedMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentedMovies.Size = new System.Drawing.Size(977, 401);
            this.rentedMovies.TabIndex = 0;
            this.rentedMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentedMovies_CellClick);
            // 
            // help
            // 
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.Location = new System.Drawing.Point(878, 11);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(111, 35);
            this.help.TabIndex = 1;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 32);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // refreshBut
            // 
            this.refreshBut.Location = new System.Drawing.Point(851, 480);
            this.refreshBut.Name = "refreshBut";
            this.refreshBut.Size = new System.Drawing.Size(119, 36);
            this.refreshBut.TabIndex = 4;
            this.refreshBut.Text = "Refresh";
            this.refreshBut.UseVisualStyleBackColor = true;
            this.refreshBut.Click += new System.EventHandler(this.refreshBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Not Seeing Your Movie?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search By Name: ";
            // 
            // userFormRented
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.rentedMovies);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userFormRented";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "userFormRented";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userFormRented_FormClosing);
            this.Load += new System.EventHandler(this.userFormRented_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentedMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rentedMovies;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button refreshBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}