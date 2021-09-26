using IteratorPattern.ConcreteAggregates;

namespace IteratorPattern
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}