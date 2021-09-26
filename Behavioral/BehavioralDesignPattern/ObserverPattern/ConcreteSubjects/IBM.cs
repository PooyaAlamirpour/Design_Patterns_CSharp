using ObserverPattern.ConcreteObservers;
using ObserverPattern.Subjects;

namespace ObserverPattern.ConcreteSubjects
{
    public class IBM : Stock
    {
        public IBM(string name, double price) : base(name, price)
        {
        }
    }
}