using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    public class BorrowHistory
    {
        public int BorrowHistoryId { get; set; }
       
        public DateTime BorrowDate { get; set; }

        public int UserId { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual User User { get; set; }

    }
}
