using System;
using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern.ConcreteObservers
{
    public class Investor : IInvestor
    {
        private readonly string _name;

        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified {_name} of {stock.Symbol}'s change to {stock.Price}");
        }
    }
}