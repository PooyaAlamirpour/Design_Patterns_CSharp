using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var loanAccount = new LoanAccountBuilder()
                .WithAccountNumber(1000)
                .WithCredential("Username", "Password")
                .WithInterestRate(4.8)
                .Build();
        }
    }
}
