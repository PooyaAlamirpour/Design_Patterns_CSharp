using StatePattern.Contexts;

namespace StatePattern.States
{
    public abstract class State
    {
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
        
        protected Account account;
        protected double balance;
        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;

        public Account Account
        {
            get => account;
            set => account = value;
        }
        public double Balance
        {
            get => balance;
            set => balance = value;
        }
    }
}