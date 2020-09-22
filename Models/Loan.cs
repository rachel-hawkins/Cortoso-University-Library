using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Loan
    {
        public int LoanID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }

        public Book Book { get; set; }
        public User User { get; set; }
    }
}
