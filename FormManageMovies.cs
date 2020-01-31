using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_MovieRental
{
    public partial class FormManageMovies : Form
    {
        MovieRentalContext context; //connect to database

        public FormManageMovies()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new MovieRentalContext();

            //Loading categories from DB
            context.Genres.Load();

            //bingding the data to the source
            this.genreBindingSource.DataSource = context.Genres.Local.ToBindingList();
        }

        private void genreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate(); // if any control has an event handler for the Validating event, it executes. 
            foreach (var movie in context.Movies.Local.ToList())
            {
                if (!movie.IsValid())
                {
                    this.context.Movies.Remove(movie);
                    MessageBox.Show("Error Updating the Database",
               "Entity Validation Exception");
                }             
            }     
            
            this.genreBindingSource.EndEdit(); // complete current edit, if any

            // try to save changes
           
            this.context.SaveChanges(); // write changes to database file
          

            //refresh database
            this.genreDataGridView.Refresh();
        }

        //menus
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
