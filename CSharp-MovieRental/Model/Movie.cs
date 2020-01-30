using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MovieRental
{
    public class Movie
    {
        private readonly ObservableListSource<BorrowHistory> borrowHistory = new ObservableListSource<BorrowHistory>();
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public decimal Rating { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public string Synopsis { get; set; }
        public string ImageURL { get; set; }
        public int GenreId { get; set; } // we have a var with this name in Genre class
        public virtual Genre Genre { get; set; }
        public virtual ObservableListSource<BorrowHistory> BorrowHistory { get { return borrowHistory; } }
    }
}
