using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_MovieRental
{
    public partial class FormReturnMovies : Form
    {
        MovieRentalContext context; //connect to database
        User returningUser;
        List<Movie> movieList;

        public FormReturnMovies()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new MovieRentalContext();

            //Loading categories from DB
            context.Movies.Load();

            //bingding the data to the source
            this.movieBindingSource.DataSource = context.Movies.Local.ToBindingList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            returningUser = context.Users.Where(u => u.Email.Equals(txtUserEmail.Text)).FirstOrDefault();
            if (returningUser != null)
            {
                lblUser.Text = returningUser.UserId.ToString();
            }

            List<BorrowHistory> bhList = context.BorrowHistories.Where(b => b.UserId == returningUser.UserId && DateTime.Compare(b.ReturnDate, new DateTime(1910,1,1,0,0,0)) < 0).ToList();

            movieList = new List<Movie>();

            foreach (BorrowHistory bh in bhList)
            {
                movieList.Add(context.Movies.Where(m => m.MovieId == bh.MovieId).FirstOrDefault());
            }
           
            this.dataGridView1.DataSource = movieList;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int movieId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            BorrowHistory borrowHistory = context.BorrowHistories.Where(b => b.UserId == returningUser.UserId && b.MovieId == movieId && DateTime.Compare(b.ReturnDate, new DateTime(1910, 1, 1, 0, 0, 0)) < 0).FirstOrDefault();

            borrowHistory.ReturnDate = DateTime.Now;

            // Save to DB
            context.SaveChanges();

            MessageBox.Show("Movie Returned Successfully!");

            // Removing Movie From the DataGridView
            this.btnSearch.PerformClick();
        }

        // Navigation
        private void manageMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormManageMovies formMovies = new FormManageMovies())
            {
                formMovies.ShowDialog();
            }
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using(FormManageUsers formUsers = new FormManageUsers())
            {
                formUsers.ShowDialog();
            }
        }

        private void returnMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Current Page
        }

        private void borrowMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormBorrowMovies borrowMovies = new FormBorrowMovies())
            {
                borrowMovies.ShowDialog();
            }
        }

    }
}

    

