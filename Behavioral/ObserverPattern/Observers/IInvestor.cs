using ObserverPattern.Subjects;

namespace ObserverPattern.Observers
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}