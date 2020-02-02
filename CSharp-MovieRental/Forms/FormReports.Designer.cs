namespace CSharp_MovieRental
{
    partial class FormReports
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
            this.OverDueMoviesDataGridView = new System.Windows.Forms.DataGridView();
            this.grpBorrowedMovies = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.borrowMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.OverDueMoviesDataGridView)).BeginInit();
            this.grpBorrowedMovies.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 79);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(848, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "OverDue Movie Report";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverDueMoviesDataGridView
            // 
            this.OverDueMoviesDataGridView.AllowUserToAddRows = false;
            this.OverDueMoviesDataGridView.AllowUserToDeleteRows = false;
            this.OverDueMoviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OverDueMoviesDataGridView.Location = new System.Drawing.Point(24, 33);
            this.OverDueMoviesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OverDueMoviesDataGridView.Name = "OverDueMoviesDataGridView";
            this.OverDueMoviesDataGridView.ReadOnly = true;
            this.OverDueMoviesDataGridView.RowHeadersWidth = 51;
            this.OverDueMoviesDataGridView.RowTemplate.Height = 24;
            this.OverDueMoviesDataGridView.Size = new System.Drawing.Size(693, 322);
            this.OverDueMoviesDataGridView.TabIndex = 0;
            // 
            // grpBorrowedMovies
            // 
            this.grpBorrowedMovies.Controls.Add(this.OverDueMoviesDataGridView);
            this.grpBorrowedMovies.Location = new System.Drawing.Point(50, 164);
            this.grpBorrowedMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBorrowedMovies.Name = "grpBorrowedMovies";
            this.grpBorrowedMovies.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBorrowedMovies.Size = new System.Drawing.Size(748, 382);
            this.grpBorrowedMovies.TabIndex = 14;
            this.grpBorrowedMovies.TabStop = false;
            this.grpBorrowedMovies.Text = "OverDue Movies";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowMoviesToolStripMenuItem,
            this.returnMoviesToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.manageMoviesToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(848, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // borrowMoviesToolStripMenuItem
            // 
            this.borrowMoviesToolStripMenuItem.Name = "borrowMoviesToolStripMenuItem";
            this.borrowMoviesToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.borrowMoviesToolStripMenuItem.Text = "Borrow Movies";
            this.borrowMoviesToolStripMenuItem.Click += new System.EventHandler(this.borrowMoviesToolStripMenuItem_Click);
            // 
            // returnMoviesToolStripMenuItem
            // 
            this.returnMoviesToolStripMenuItem.Name = "returnMoviesToolStripMenuItem";
            this.returnMoviesToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.returnMoviesToolStripMenuItem.Text = "Return Movies";
            this.returnMoviesToolStripMenuItem.Click += new System.EventHandler(this.returnMoviesToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // manageMoviesToolStripMenuItem
            // 
            this.manageMoviesToolStripMenuItem.Name = "manageMoviesToolStripMenuItem";
            this.manageMoviesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.manageMoviesToolStripMenuItem.Text = "Manage Movies";
            this.manageMoviesToolStripMenuItem.Click += new System.EventHandler(this.manageMoviesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Location = new System.Drawing.Point(678, 559);
            this.btnSaveReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(120, 23);
            this.btnSaveReport.TabIndex = 16;
            this.btnSaveReport.Text = "Save to File";
            this.btnSaveReport.UseVisualStyleBackColor = true;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(595, 138);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(58, 17);
            this.lblSort.TabIndex = 17;
            this.lblSort.Text = "Sort By:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "User ID",
            "Movie ID",
            "Borrow Date"});
            this.comboBox1.Location = new System.Drawing.Point(671, 132);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(848, 605);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnSaveReport);
            this.Controls.Add(this.grpBorrowedMovies);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReports";
            this.Text = "FormReports";
            ((System.ComponentModel.ISupportInitialize)(this.OverDueMoviesDataGridView)).EndInit();
            this.grpBorrowedMovies.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView OverDueMoviesDataGridView;
        private System.Windows.Forms.GroupBox grpBorrowedMovies;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem borrowMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
