using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    public class Account
    {
        public long AccountNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double LoanAmount { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
    }
}
