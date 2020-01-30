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
//using System.Web.UI.WebControls;
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
            context.Genres.Load();

            context.Users.Load();

            //bingding the data to the source
            this.genreBindingSource.DataSource = context.Genres.Local.ToBindingList();

            this.userBindingSource.DataSource = context.Users.Local.ToBindingList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            User borrowingUser = context.Users.Where(u => u.Email.Equals(emailTextBox.Text)).FirstOrDefault();
            if (borrowingUser != null)
            {

            }

            //int useId = (int)userDataGridView.CurrentRow.Cells[0].Value;
            //int userId = borrowingUser.UserId;

            int movieId = (int)movieDataGridView.CurrentRow.Cells[0].Value;
            //lblUserId.Text = "userId:"+useId +" MovieId: "+movieId;

            string connetionString = null;
            SqlConnection cnn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = null;
            connetionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CSharp_MovieRental.MovieRentalContext;Integrated Security=True";

            cnn = new SqlConnection(connetionString);


            sql = "INSERT INTO BorrowHistories (BorrowDate, UserId, MovieId) VALUES (" + "'" + DateTime.Now + "'" + "," + borrowingUser.UserId + "," + movieId + ")";

            try
            {
                cnn.Open();
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Row inserted !! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            /*
            System.Data.SqlClient.SqlConnection sqlConnection1 =
    new System.Data.SqlClient.SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CSharp_MovieRental.MovieRentalContext;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO BorrowHistories (BorrowDate, UserId, MovieId) VALUES ("+DateTime.UtcNow.Date+","+ useId+","+movieId+")";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            */
        }
    }
}