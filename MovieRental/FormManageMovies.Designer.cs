﻿namespace MovieRental
{
    partial class FormManageMovies
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageMovies));
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label imageURLLabel;
            System.Windows.Forms.Label movieIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label synopsisLabel;
            System.Windows.Forms.Label yearLabel;
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.genreBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.genreMoviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.imageURLTextBox = new System.Windows.Forms.TextBox();
            this.movieIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.synopsisTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            directorLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            imageURLLabel = new System.Windows.Forms.Label();
            movieIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            synopsisLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingNavigator)).BeginInit();
            this.genreBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreMoviesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(MovieRental.Genre);
            // 
            // genreBindingNavigator
            // 
            this.genreBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.genreBindingNavigator.BindingSource = this.genreBindingSource;
            this.genreBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.genreBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.genreBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.genreBindingNavigatorSaveItem});
            this.genreBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.genreBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.genreBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.genreBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.genreBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.genreBindingNavigator.Name = "genreBindingNavigator";
            this.genreBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.genreBindingNavigator.Size = new System.Drawing.Size(953, 25);
            this.genreBindingNavigator.TabIndex = 0;
            this.genreBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // genreBindingNavigatorSaveItem
            // 
            this.genreBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.genreBindingNavigatorSaveItem.Enabled = false;
            this.genreBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("genreBindingNavigatorSaveItem.Image")));
            this.genreBindingNavigatorSaveItem.Name = "genreBindingNavigatorSaveItem";
            this.genreBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.genreBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // genreComboBox
            // 
            this.genreComboBox.DataSource = this.genreBindingSource;
            this.genreComboBox.DisplayMember = "Name";
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(166, 328);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(300, 21);
            this.genreComboBox.TabIndex = 1;
            this.genreComboBox.ValueMember = "GenreId";
            // 
            // genreMoviesBindingSource
            // 
            this.genreMoviesBindingSource.DataMember = "GenreMovies";
            this.genreMoviesBindingSource.DataSource = this.genreBindingSource;
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(173, 63);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(47, 13);
            directorLabel.TabIndex = 2;
            directorLabel.Text = "Director:";
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genreMoviesBindingSource, "Movie.Director", true));
            this.directorTextBox.Location = new System.Drawing.Point(243, 60);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(100, 20);
            this.directorTextBox.TabIndex = 3;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(173, 89);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(50, 13);
            durationLabel.TabIndex = 4;
            durationLabel.Text = "Duration:";
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genreMoviesBindingSource, "Movie.Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(243, 86);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 20);
            this.durationTextBox.TabIndex = 5;
            // 
            // imageURLLabel
            // 
            imageURLLabel.AutoSize = true;
            imageURLLabel.Location = new System.Drawing.Point(173, 115);
            imageURLLabel.Name = "imageURLLabel";
            imageURLLabel.Size = new System.Drawing.Size(64, 13);
            imageURLLabel.TabIndex = 6;
            imageURLLabel.Text = "Image URL:";
            // 
            // imageURLTextBox
            // 
            this.imageURLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genreMoviesBindingSource, "Movie.ImageURL", true));
            this.imageURLTextBox.Location = new System.Drawing.Point(243, 112);
            this.imageURLTextBox.Name = "imageURLTextBox";
            this.imageURLTextBox.Size = new System.Drawing.Size(100, 20);
            this.imageURLTextBox.TabIndex = 7;
            // 
            // movieIdLabel
            // 
            movieIdLabel.AutoSize = true;
            movieIdLabel.Location = new System.Drawing.Point(173, 141);
            movieIdLabel.Name = "movieIdLabel";
            movieIdLabel.Size = new System.Drawing.Size(51, 13);
            movieIdLabel.TabIndex = 8;
            movieIdLabel.Text = "Movie Id:";
            // 
            // movieIdTextBox
            // 
            this.movieIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genreMoviesBindingSource, "Movie.MovieId", true));
            this.movieIdTextBox.Location = new System.Drawing.Point(243, 138);
            this.movieIdTextBox.Name = "movieIdTextBox";
            this.movieIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.movieIdTextBox.TabIndex = 9;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(173, 167);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genreMoviesBindingSource, "Movie.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(243, 164);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(173, 193);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(41, 13);
            ratingLabel.TabIndex = 12;
            ratingLabel.Text = "Rating:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genreMoviesBindingSource, "Movie.Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(243, 190);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(100, 20);
            this.ratingTextBox.TabIndex = 13;
            // 
            // synopsisLabel
            // 
            synopsisLabel.AutoSize = true;
            synopsisLabel.Location = new System.Drawing.Point(173, 219);
            synopsisLabel.Name = "synopsisLabel";
            synopsisLabel.Size = new System.Drawing.Size(52, 13);
            synopsisLabel.TabIndex = 14;
            synopsisLabel.Text = "Synopsis:";
            // 
            // synopsisTextBox
            // 
            this.synopsisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genreMoviesBindingSource, "Movie.Synopsis", true));
            this.synopsisTextBox.Location = new System.Drawing.Point(243, 216);
            this.synopsisTextBox.Name = "synopsisTextBox";
            this.synopsisTextBox.Size = new System.Drawing.Size(100, 20);
            this.synopsisTextBox.TabIndex = 15;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(173, 245);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 16;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genreMoviesBindingSource, "Movie.Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(243, 242);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 17;
            // 
            // FormManageMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 528);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(imageURLLabel);
            this.Controls.Add(this.imageURLTextBox);
            this.Controls.Add(movieIdLabel);
            this.Controls.Add(this.movieIdTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(synopsisLabel);
            this.Controls.Add(this.synopsisTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.genreBindingNavigator);
            this.Name = "FormManageMovies";
            this.Text = "FormManageMovies";
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingNavigator)).EndInit();
            this.genreBindingNavigator.ResumeLayout(false);
            this.genreBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreMoviesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.BindingNavigator genreBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton genreBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.BindingSource genreMoviesBindingSource;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox imageURLTextBox;
        private System.Windows.Forms.TextBox movieIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox synopsisTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
    }
}