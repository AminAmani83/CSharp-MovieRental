using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_MovieRental
{
    public partial class FormBorrowMovies : Form
    {
        MovieRentalContext context; //connect to database
        public FormBorrowMovies()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new MovieRentalContext();

            //Loading 
            context.Genres.Load();
            context.Users.Load();
            context.Movies.Load();

            //bingding the data to the source
            this.genreBindingSource.DataSource = context.Genres.Local.ToBindingList();

            this.userBindingSource.DataSource = context.Users.Local.ToBindingList();
            
            List<BorrowHistory> unAvailableBorrowHistoryList = context.BorrowHistories.Where(b => DateTime.Compare(b.ReturnDate, new DateTime(1910, 1, 1, 0, 0, 0)) < 0).ToList();
            List<Movie> allMovieList = context.Movies.ToList();
            foreach (BorrowHistory unAvailableBorrowHistory in unAvailableBorrowHistoryList)
            {
                int movieIndex = allMovieList.IndexOf(unAvailableBorrowHistory.Movie);
                allMovieList.RemoveAt(movieIndex);
            }
            this.movieDataGridView.DataSource = allMovieList;
            emailTextBox.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchMovie.Text))
            {
                // Showing All Movies
                OnLoad(e);
            }
            else
            {
                List<BorrowHistory> unAvailableBorrowHistoryList = context.BorrowHistories.Where(b => DateTime.Compare(b.ReturnDate, new DateTime(1910, 1, 1, 0, 0, 0)) < 0).ToList();
                List<Movie> allMovieList = context.Movies.ToList();
                foreach (BorrowHistory unAvailableBorrowHistory in unAvailableBorrowHistoryList)
                {
                    int movieIndex = allMovieList.IndexOf(unAvailableBorrowHistory.Movie);
                    allMovieList.RemoveAt(movieIndex);
                }

                List<Movie> resultMovieList = new List<Movie>();

                bool result = false;
                List<Movie> searchMovie = context.Movies.Where(m => m.Name.Contains(txtSearchMovie.Text)).ToList();
                if (searchMovie != null)
                {
                    //lblMovie.Text = searchMovie.MovieId.ToString();
                    foreach (Movie movie in allMovieList)
                    {
                        foreach (Movie s in searchMovie)
                        {
                            if (s.MovieId.Equals(movie.MovieId))
                            {
                                resultMovieList.Add(movie);
                                result = true;
                            }

                        }
                    }
                    if (result == true)
                    {
                        this.movieDataGridView.DataSource = resultMovieList;
                    }
                    else
                    {
                        MessageBox.Show("Sorry, Movie is Not Available","Search Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        // txtSearchMovie.Text = "";
                        OnLoad(e);
                    }

                }
                else
                {
                    if (String.IsNullOrEmpty(txtSearchMovie.Text))
                    {
                        MessageBox.Show("Please type any movie name", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sorry Movie is Not Available", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSearchMovie.Text = "";
                    }
                    this.movieDataGridView.DataSource = allMovieList;
                }
            }

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            User borrowingUser = context.Users.Where(u => u.Email.Equals(emailTextBox.Text)).FirstOrDefault();

            int movieId = (int)this.movieDataGridView.CurrentRow.Cells[0].Value;

            string connetionString = null;
            SqlConnection cnn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = null;
            connetionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CSharp_MovieRental.MovieRentalContext;Integrated Security=True";

            cnn = new SqlConnection(connetionString);

            if (borrowingUser == null)
            {
                MessageBox.Show("Please Enter Valid Email");
                emailTextBox.Text = "";
            }
            else
            {
                sql = "INSERT INTO BorrowHistories (BorrowDate, UserId, MovieId) VALUES (" + "'" + DateTime.Now + "'" + "," + borrowingUser.UserId + "," + movieId + ")";
                try
                {
                    cnn.Open();
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Movie Borrowed Successfully ! ", "Borrow Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearchMovie.Text = "";
                    OnLoad(e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
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
            using (FormManageUsers formUsers = new FormManageUsers())
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
            // Current Page
        }

        private void comboGenre_MouseClick(object sender, MouseEventArgs e)
        {
            comboGenre.Items.Clear();

            List<Genre> gettingGenres = context.Genres.ToList();
            foreach (Genre genre in gettingGenres)
            {
                this.comboGenre.Items.Add(genre.Name);
            }
        }
    }
}
