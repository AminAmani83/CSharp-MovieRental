using MovieRental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    public class Movie
    {
        private readonly ObservableListSource<BorrowHistory> borrowHistory = new ObservableListSource<BorrowHistory>();
        private readonly ObservableListSource<GenreMovies> genreMovies = new ObservableListSource<GenreMovies>();

        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public decimal Rating { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public string Synopsis { get; set; }
        public string ImageURL { get; set; }

        public virtual ObservableListSource<GenreMovies> GenreMovies { get { return genreMovies; } }
        public virtual ObservableListSource<BorrowHistory> BorrowHistory { get { return borrowHistory; } }

        //  public int GenreId { get; set; }
        //  public virtual Genre Genre { get; set; }

        //public int GenreMovieId { get; set; }
        //public virtual GenreMovies GenreMovies { get; set; }
    }
}
