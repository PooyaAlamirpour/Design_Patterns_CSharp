using System;
using ObserverPattern.ConcreteObservers;
using ObserverPattern.ConcreteSubjects;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ibm = new IBM("IBM", 120.0);
            ibm.Attach(new Investor("Investor one"));
            ibm.Attach(new Investor("Investor two"));

            var btc = new BTC("BTC", 40000.0);
            btc.Attach(new Investor("Investor btc one"));
            btc.Attach(new Investor("Investor btc two"));
            btc.Attach(new Investor("Investor btc three"));
            
            ibm.Price = 121.0;
            ibm.Price = 121.0;

            btc.Price = 40001.0;
            btc.Price = 40002.0;
        }
    }
}