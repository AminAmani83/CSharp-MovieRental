using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
   public class Genre
    {
        private readonly ObservableListSource<Movie> movie = new ObservableListSource<Movie>();
        public int GenreId { get; set; }
        public string Name { get; set; }
        public virtual ObservableListSource<Movie> Movie { get { return movie; } }

    }
}
