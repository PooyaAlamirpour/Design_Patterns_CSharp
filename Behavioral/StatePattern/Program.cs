using System;
using StatePattern.Contexts;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account("Jim Josh");

            account.Deposit(500.0);
            account.Deposit(100.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
        }
    }
}