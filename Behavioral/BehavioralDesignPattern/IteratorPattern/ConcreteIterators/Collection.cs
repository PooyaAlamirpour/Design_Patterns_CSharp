using System.Collections.Generic;
using IteratorPattern.ConcreteAggregates;

namespace IteratorPattern.ConcreteIterators
{
    public class Collection : IAbstractCollection
    {
        private List<Item> _items = new List<Item>();
        public Item this[int index]
        {
            get => _items[index];
            set => _items.Add(value);
        }

        public int Count => _items.Count;

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
    }
}