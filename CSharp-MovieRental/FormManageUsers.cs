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
            clearFields();
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;

            // binding the data to the source
            this.borrowHistoryBindingSource.DataSource = context.Users.Add(new User());

            // populate user list
            List<User> userList = context.Users.ToList();
            this.dataGridViewUsers.DataSource = userList;
            dataGridViewUsers.Columns[0].Visible = false;
        }

        private void borrowHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate(); // if any control has an event handler for the Validating event, it executes. 
            
            /*
            foreach (var user in context.Users.Local.ToList())
            {
                if (!user.IsValid())
                {
                    //this.context.Users.Remove(user);
                    //MessageBox.Show("Error Updating the Database","Entity Validation Exception");
                    MessageBox.Show("User is invalid");
                }
            }
            */

            this.borrowHistoryBindingSource.EndEdit(); // complete current edit, if any

            this.context.SaveChanges(); // write changes to database file

            //refresh page
            //clearFields();
            OnLoad(e);
        }

        #region Navigation
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
            // Current Page
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
        #endregion

        public void clearFields()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
        }

        private void dataGridViewUsers_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow.Index != -1)
            {
                User selectedUser = (User)dataGridViewUsers.CurrentRow.DataBoundItem;
                //MessageBox.Show("Hello"+selectedUser.FirstName);
                firstNameTextBox.Text = selectedUser.FirstName;
                lastNameTextBox.Text = selectedUser.LastName;
                emailTextBox.Text = selectedUser.Email;
                phoneTextBox.Text = selectedUser.Phone;
                btnSave.Text = "UPDATE";
                btnDelete.Enabled = true;
            }
        }
    }
}
