using Builder.Builder;
using Builder.Director;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //var loanAccount = new LoanAccountBuilder()
            //    .WithAccountNumber(1000)
            //    .WithCredential("Username", "Password")
            //    .WithInterestRate(4.8)
            //    .Build();

            IAccountBuilder builder = new ConcreteBuilder.LoanAccountBuilder();
            AccountConfigurationBuilder configureBuilder = new AccountConfigurationBuilder();
            var account = configureBuilder.BuildLoanAccount(builder);                                         //Build new account with new configuration

            Console.WriteLine($"AccountNumber: {account.AccountNumber} - LoanAmount: {account.LoanAmount}");

        }
    }
}
