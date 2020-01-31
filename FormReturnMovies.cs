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

            List<Movie> movieList = new List<Movie>();

            List<BorrowHistory> bhList = context.BorrowHistories.Where(b => b.UserId == returningUser.UserId && DateTime.Compare(b.ReturnDate, new DateTime(1910,1,1,0,0,0)) < 0).ToList();
            //label2.Text = bhList.Count.ToString();
            foreach (BorrowHistory bh in bhList)
            {
                movieList.Add(context.Movies.Where(m => m.MovieId == bh.MovieId).FirstOrDefault());
            }
           
            this.dataGridView1.DataSource = movieList;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int movieId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            //label2.Text = movieId.ToString();

            BorrowHistory borrowHistory = context.BorrowHistories.Where(b => b.UserId == returningUser.UserId && b.MovieId == movieId && DateTime.Compare(b.ReturnDate, new DateTime(1910, 1, 1, 0, 0, 0)) < 0).FirstOrDefault();
            //label2.Text = borrowHistory.MovieId.ToString();

            borrowHistory.ReturnDate = DateTime.Now;

            context.SaveChanges();
            this.dataGridView1.Refresh();
        }
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
            this.Hide();

            using (FormReturnMovies returnMovies = new FormReturnMovies())
            {
                returnMovies.ShowDialog();
            }
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

    

