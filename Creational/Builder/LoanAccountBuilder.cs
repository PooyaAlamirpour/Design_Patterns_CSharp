using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LoanAccountBuilder
    {
        private long _accountNumber { get; set; }
        private string _username { get; set; }
        private string _password { get; set; }
        private double _loanAmount { get; set; }
        private double _interestRate { get; set; }

        public LoanAccountBuilder WithAccountNumber(int accountNumber)
        {
            this._accountNumber = accountNumber;
            return this;
        }

        public LoanAccountBuilder WithCredential(string username, string password)
        {
            this._username = username;
            this._password = password;
            return this;
        }

        public LoanAccountBuilder WithLoanAmount(double loanAmount)
        {
            this._loanAmount = loanAmount;
            return this;
        }

        public LoanAccountBuilder WithInterestRate(double interestRate)
        {
            this._interestRate = interestRate;
            return this;
        }

        private bool CanBuild() => _accountNumber > 0;

        public LoanAccountBuilder Build() => CanBuild() ? this : throw new Exception("Can not build a valid object.");
    }
}
