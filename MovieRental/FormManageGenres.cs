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

namespace MovieRental
{
    public partial class FormManageGenres : Form
    {
        MovieRentalContext context;//connect to database

        public FormManageGenres()
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
            this.Validate();

            //save to database
            this.context.SaveChanges();

            //refresh database
            //this.genreDataGridView.Refresh();
        }
    }
}
