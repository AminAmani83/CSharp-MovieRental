namespace CSharp_MovieRental
{
    partial class FormBorrowMovies
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpSearchBox = new System.Windows.Forms.GroupBox();
            this.btnSearchMoviesSubmit = new System.Windows.Forms.Button();
            this.cbxSearchMovieGenre = new System.Windows.Forms.ComboBox();
            this.lblSearchMovieGenre = new System.Windows.Forms.Label();
            this.lblSearchMovieName = new System.Windows.Forms.Label();
            this.txtSearchMovieName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.borrowMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearchResults = new System.Windows.Forms.GroupBox();
            this.grpBorrow = new System.Windows.Forms.GroupBox();
            this.grpSearchBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpSearchResults.SuspendLayout();
            this.grpBorrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(208, 48);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Borrow Movies";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 29);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(101, 12);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Username (Email)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 21);
            this.textBox1.TabIndex = 2;
            // 
            // grpSearchBox
            // 
            this.grpSearchBox.Controls.Add(this.btnSearchMoviesSubmit);
            this.grpSearchBox.Controls.Add(this.cbxSearchMovieGenre);
            this.grpSearchBox.Controls.Add(this.lblSearchMovieGenre);
            this.grpSearchBox.Controls.Add(this.lblSearchMovieName);
            this.grpSearchBox.Controls.Add(this.txtSearchMovieName);
            this.grpSearchBox.Location = new System.Drawing.Point(54, 99);
            this.grpSearchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSearchBox.Name = "grpSearchBox";
            this.grpSearchBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSearchBox.Size = new System.Drawing.Size(458, 107);
            this.grpSearchBox.TabIndex = 3;
            this.grpSearchBox.TabStop = false;
            this.grpSearchBox.Text = "Search in Movies";
            // 
            // btnSearchMoviesSubmit
            // 
            this.btnSearchMoviesSubmit.Location = new System.Drawing.Point(374, 25);
            this.btnSearchMoviesSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchMoviesSubmit.Name = "btnSearchMoviesSubmit";
            this.btnSearchMoviesSubmit.Size = new System.Drawing.Size(56, 54);
            this.btnSearchMoviesSubmit.TabIndex = 6;
            this.btnSearchMoviesSubmit.Text = "Search";
            this.btnSearchMoviesSubmit.UseVisualStyleBackColor = true;
            // 
            // cbxSearchMovieGenre
            // 
            this.cbxSearchMovieGenre.FormattingEnabled = true;
            this.cbxSearchMovieGenre.Location = new System.Drawing.Point(114, 61);
            this.cbxSearchMovieGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSearchMovieGenre.Name = "cbxSearchMovieGenre";
            this.cbxSearchMovieGenre.Size = new System.Drawing.Size(231, 20);
            this.cbxSearchMovieGenre.TabIndex = 5;
            // 
            // lblSearchMovieGenre
            // 
            this.lblSearchMovieGenre.AutoSize = true;
            this.lblSearchMovieGenre.Location = new System.Drawing.Point(5, 61);
            this.lblSearchMovieGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchMovieGenre.Name = "lblSearchMovieGenre";
            this.lblSearchMovieGenre.Size = new System.Drawing.Size(35, 12);
            this.lblSearchMovieGenre.TabIndex = 2;
            this.lblSearchMovieGenre.Text = "Genre";
            // 
            // lblSearchMovieName
            // 
            this.lblSearchMovieName.AutoSize = true;
            this.lblSearchMovieName.Location = new System.Drawing.Point(5, 29);
            this.lblSearchMovieName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchMovieName.Name = "lblSearchMovieName";
            this.lblSearchMovieName.Size = new System.Drawing.Size(29, 12);
            this.lblSearchMovieName.TabIndex = 1;
            this.lblSearchMovieName.Text = "Name";
            // 
            // txtSearchMovieName
            // 
            this.txtSearchMovieName.Location = new System.Drawing.Point(114, 26);
            this.txtSearchMovieName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchMovieName.Name = "txtSearchMovieName";
            this.txtSearchMovieName.Size = new System.Drawing.Size(231, 21);
            this.txtSearchMovieName.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 75);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(358, 26);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(84, 17);
            this.btnBorrow.TabIndex = 6;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowMoviesToolStripMenuItem,
            this.returnMoviesToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.manageMoviesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // borrowMoviesToolStripMenuItem
            // 
            this.borrowMoviesToolStripMenuItem.Name = "borrowMoviesToolStripMenuItem";
            this.borrowMoviesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.borrowMoviesToolStripMenuItem.Text = "Borrow Movies";
            // 
            // returnMoviesToolStripMenuItem
            // 
            this.returnMoviesToolStripMenuItem.Name = "returnMoviesToolStripMenuItem";
            this.returnMoviesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.returnMoviesToolStripMenuItem.Text = "Return Movies";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // manageMoviesToolStripMenuItem
            // 
            this.manageMoviesToolStripMenuItem.Name = "manageMoviesToolStripMenuItem";
            this.manageMoviesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.manageMoviesToolStripMenuItem.Text = "Manage Movies";
            // 
            // grpSearchResults
            // 
            this.grpSearchResults.Controls.Add(this.tableLayoutPanel1);
            this.grpSearchResults.Location = new System.Drawing.Point(54, 221);
            this.grpSearchResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSearchResults.Name = "grpSearchResults";
            this.grpSearchResults.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSearchResults.Size = new System.Drawing.Size(458, 125);
            this.grpSearchResults.TabIndex = 8;
            this.grpSearchResults.TabStop = false;
            this.grpSearchResults.Text = "Search Results";
            // 
            // grpBorrow
            // 
            this.grpBorrow.Controls.Add(this.textBox1);
            this.grpBorrow.Controls.Add(this.btnBorrow);
            this.grpBorrow.Controls.Add(this.lblEmail);
            this.grpBorrow.Location = new System.Drawing.Point(54, 362);
            this.grpBorrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBorrow.Name = "grpBorrow";
            this.grpBorrow.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBorrow.Size = new System.Drawing.Size(458, 60);
            this.grpBorrow.TabIndex = 9;
            this.grpBorrow.TabStop = false;
            this.grpBorrow.Text = "Borrow";
            // 
            // FormBorrowMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.grpBorrow);
            this.Controls.Add(this.grpSearchResults);
            this.Controls.Add(this.grpSearchBox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBorrowMovies";
            this.Text = "Borrow Movies";
            this.grpSearchBox.ResumeLayout(false);
            this.grpSearchBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSearchResults.ResumeLayout(false);
            this.grpBorrow.ResumeLayout(false);
            this.grpBorrow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpSearchBox;
        private System.Windows.Forms.Label lblSearchMovieGenre;
        private System.Windows.Forms.Label lblSearchMovieName;
        private System.Windows.Forms.TextBox txtSearchMovieName;
        private System.Windows.Forms.ComboBox cbxSearchMovieGenre;
        private System.Windows.Forms.Button btnSearchMoviesSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem borrowMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMoviesToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSearchResults;
        private System.Windows.Forms.GroupBox grpBorrow;
    }
}

