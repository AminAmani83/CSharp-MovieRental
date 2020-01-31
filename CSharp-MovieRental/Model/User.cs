using CSharp_MovieRental.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp_MovieRental
{
    public class User : IValidation
    {
        private readonly ObservableListSource<BorrowHistory> borrowHistory = new ObservableListSource<BorrowHistory>();
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ObservableListSource<BorrowHistory> BorrowHistory { get { return borrowHistory; } }

        public bool IsValid()
        {
            return (this.Validate().Count() == 0);
        }

        public IEnumerable<string> Validate()
        {
            string pattern = "^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$";
            if (string.IsNullOrEmpty(this.FirstName))
            {
                yield return "First Name is mandatory.";
            }
            if (string.IsNullOrEmpty(this.LastName))
            {
                yield return "Last Name is mandatory.";
            }

            if (string.IsNullOrEmpty(this.Email))
            {
                yield return "Email is mandatory.";
            }
           // else if (!Regex.Match(this.Email, pattern).Success)

          //  {
          //      yield return "Email is not correct.";
           // }
            if (string.IsNullOrEmpty(this.Phone))
            {
                yield return "Phone is mandatory.";
                
            }
        }
    }
}
