using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Model
{
    public class GenreMovies
    {
        //private readonly ObservableListSource<Genre> genres = new ObservableListSource<Genre>();
        //private readonly ObservableListSource<Movie> movies = new ObservableListSource<Movie>();

        public int GenreMoviesId { get; set; }

        
        public int MovieId { get; set; }        
        public int GenreId { get; set; }        

        public virtual Movie Movie { get; set; }
        public virtual Genre Genre { get; set; }
        //public virtual ObservableListSource<Genre> Genre { get { return genres; } }
        //public virtual ObservableListSource<Movie> Movie { get { return movies; } }
    }
}
