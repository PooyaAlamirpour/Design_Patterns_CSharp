using ObserverPattern.ConcreteObservers;
using ObserverPattern.Subjects;

namespace ObserverPattern.ConcreteSubjects
{
    public class BTC : Stock
    {
        public BTC(string name, double price) : base(name, price)
        {
        }
    }
}