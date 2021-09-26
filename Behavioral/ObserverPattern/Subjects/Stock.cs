using System;
using System.Collections.Generic;
using ObserverPattern.ConcreteObservers;
using ObserverPattern.Observers;

namespace ObserverPattern.Subjects
{
    public abstract class Stock
    {
        private List<IInvestor> _investorList = new();
        private double _price;

        protected Stock(string name, double price)
        {
            this.Symbol = name;
            this._price = price;
        }

        public double Price
        {
            get => _price;
            set
            {
                if (Math.Abs(_price - value) < 0.001) return;
                _price = value;
                Notify();
            }
        }

        public string Symbol { get; set; }

        private void Notify()
        {
            foreach (var investor in _investorList)
            {
                investor.Update(this);
            }
        }
        
        public void Attach(IInvestor investor)
        {
            _investorList.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investorList.Remove(investor);
        }
    }
}