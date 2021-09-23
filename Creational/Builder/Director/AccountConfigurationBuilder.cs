using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    public class AccountConfigurationBuilder
    {
        public Account BuildLoanAccount(IAccountBuilder builder)
        {
            builder.AddAccountNumber(123456);
            builder.WithLoanAmount(5000);
            builder.AddInterestRate(4.8);

            return builder.GetAccount();
        }

        public Account BuildSavingccount(IAccountBuilder builder)
        {
            builder.AddAccountNumber(654321);
            builder.WithSavingBalance();

            return builder.GetAccount();
        }
    }
}
