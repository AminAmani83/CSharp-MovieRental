using MovieRental.Model;
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
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BorrowHistory> BorrowHistories { get; set; }
        public DbSet<GenreMovies> GenreMovies { get; set; }

        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Movie>()
                        .HasMany(s => s.Genr)
                        .WithMany(c => c.Movie)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("StudentRefId");
                            cs.MapRightKey("CourseRefId");
                            cs.ToTable("StudentCourse");
                        });

        }
        */
    }
}
