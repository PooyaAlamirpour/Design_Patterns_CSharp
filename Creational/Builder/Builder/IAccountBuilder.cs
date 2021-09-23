using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public interface IAccountBuilder
    {
        void AddAccountNumber(long accountNumber);
        void AddCredential(string username, string password);
        void WithLoanAmount(double loanAmount);
        void AddInterestRate(double interestRate);
        void WithSavingBalance();
        Account GetAccount(); 
    }
}
