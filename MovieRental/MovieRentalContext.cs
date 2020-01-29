using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    public class MovieRentalContext : DbContext
    {
        public DbSet<Movie> Moives { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BorrowHistory> BorrowHistories { get; set; }
    }
}
