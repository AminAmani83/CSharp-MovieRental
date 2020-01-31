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
    public partial class FormManageUsers : Form
    {
        MovieRentalContext context; //connect to database
        public FormManageUsers()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new MovieRentalContext();

            //Loading categories from DB
            //context.Users.Load();

            //bingding the data to the source
            this.borrowHistoryBindingSource.DataSource = context.Users.Add(new User());
                
        }

        private void borrowHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate(); // if any control has an event handler for the Validating event, it executes. 

            //this.borrowHistoryBindingSource.EndEdit(); // complete current edit, if any

            // try to save changes
            try
            {
                this.context.SaveChanges(); // write changes to database file
                //this.firstNameTextBox.Clear();
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("Error Updating the Database",
                "Entity Validation Exception");
            }

            //refresh database
            this.firstNameTextBox.Refresh();
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
