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
            User returningUser = context.Users.Where(u => u.Email.Equals(txtUserEmail.Text)).FirstOrDefault();
            if (returningUser != null)
            {
                lblUser.Text = returningUser.UserId.ToString();
            }
            
        }
    }
}
