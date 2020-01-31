using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_MovieRental
{
    public partial class FormReports : Form
    {
        MovieRentalContext context; //connect to database
        List<BorrowHistory> bhList;
        int overDueAfterThisManyDays = -1; // Days (temporarily set to a negative number for testing)
        
        public FormReports()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new MovieRentalContext();

            DateTime overDueDate = DateTime.Today.AddDays(-overDueAfterThisManyDays);

            // Find the records (in the borrowHistory table) related to movies that were borrowed by this user but never returned (return date is 1900)
            bhList = context.BorrowHistories.Where(b => DateTime.Compare(b.BorrowDate, overDueDate) < 0 && DateTime.Compare(b.ReturnDate, new DateTime(1910, 1, 1, 0, 0, 0)) < 0).ToList();


            //bingding the data to the source
            this.OverDueMoviesDataGridView.DataSource = bhList;
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("OverDueList.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    // Write table titels to file
                    sw.WriteLine($"User Id \t User Email \t\t Movie Id \t Movie Name \t\t Borrow Date");

                    foreach (BorrowHistory bh in bhList)
                    {
                        // Fetch info about the user and the movie (like a SQL join)
                        User user = context.Users.Where(u => u.UserId == bh.UserId).FirstOrDefault();
                        Movie movie = context.Movies.Where(m => m.MovieId == bh.MovieId).FirstOrDefault();
                        // Write Info
                        sw.WriteLine($"{bh.UserId} \t\t {user.Email} \t\t {bh.MovieId} \t\t {movie.Name} \t\t {bh.BorrowDate}");
                    }
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                    MessageBox.Show("File Saved Successfully", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.Hide();
            using (FormBorrowMovies borrowMovies = new FormBorrowMovies())
            {
                borrowMovies.ShowDialog();
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Current Page
        }
    }
}
