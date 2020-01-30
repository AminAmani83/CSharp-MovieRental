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

            //Loading categories from DB
            context.Movies.Load();

            //bingding the data to the source
            this.movieBindingSource.DataSource = context.Movies.Local.ToBindingList();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            int selectedRowNumber = movieDataGridView.CurrentCell.RowIndex;
            this.lblCell.Text = "Selected MovieId: " +
                movieDataGridView.Rows[selectedRowNumber].Cells[0].Value.ToString();
        }
    }
}
