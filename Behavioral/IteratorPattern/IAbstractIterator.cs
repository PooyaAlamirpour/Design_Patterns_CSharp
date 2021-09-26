namespace IteratorPattern
{
    public interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        string CurrentItem { get; }

        void reset();
    }
}