using System.Collections.Generic;

namespace StrategyPattern.Strategies
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}