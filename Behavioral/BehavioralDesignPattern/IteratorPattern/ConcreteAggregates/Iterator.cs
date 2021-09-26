using IteratorPattern.ConcreteIterators;

namespace IteratorPattern.ConcreteAggregates
{
    public class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _currentIndex = 0;
        
        public Iterator(Collection collection) => this._collection = collection;

        public Item First() => _collection[0];

        public Item Next()
        {
            _currentIndex++;
            return !IsDone ? _collection[_currentIndex] : null;
        }

        public bool IsDone => _currentIndex >= _collection.Count;

        public string CurrentItem => _collection[_currentIndex].Value;
        
        public void reset() => this._currentIndex = 0;
    }
}