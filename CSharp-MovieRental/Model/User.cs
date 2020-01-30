using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MovieRental
{
    public class User
    {
        private readonly ObservableListSource<BorrowHistory> borrowHistory = new ObservableListSource<BorrowHistory>();
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ObservableListSource<BorrowHistory> BorrowHistory { get { return borrowHistory; } }

    }
}
