using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ConcreteBuilder
{
    public class LoanAccountBuilder : IAccountBuilder
    {
        private Account _loanAccount = new Account();

        public void AddAccountNumber(long accountNumber)
        {
            this._loanAccount.AccountNumber = accountNumber;
        }

        public void AddCredential(string username, string password)
        {
            this._loanAccount.Username = username;
            this._loanAccount.Password = password;
        }

        public void AddInterestRate(double interestRate)
        {
            this._loanAccount.InterestRate = interestRate;
        }

        public void WithLoanAmount(double loanAmount)
        {
            this._loanAccount.LoanAmount = loanAmount;
        }

        public void WithSavingBalance()
        {
            this._loanAccount.Balance = 100000;
        }

        public Account GetAccount()
        {
            return _loanAccount;
        }
    }
}
