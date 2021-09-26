using System;
using System.Collections.Generic;
using StrategyPattern.ConcreteStrategies;
using StrategyPattern.Strategies;

namespace StrategyPattern.Contexts
{
    public class SortedList
    {
        private SortStrategy _sortStrategy;
        private List<string> _list = new();
        
        public void SetSortStrategy(SortStrategy strategy)
        {
            this._sortStrategy = strategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);
            
            foreach (var name in _list)
            {
                Console.WriteLine($"> {name}");
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}