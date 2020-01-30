using MovieRental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
   public class Genre
    {
        private readonly ObservableListSource<GenreMovies> genreMovies = new ObservableListSource<GenreMovies>();

        public int GenreId { get; set; }
        public string Name { get; set; }

        public virtual ObservableListSource<GenreMovies> GenreMovies { get { return genreMovies; } }


        //public int GenreMovieId { get; set; }
        //public virtual GenreMovies GenreMovies { get; set; }
    }
}
