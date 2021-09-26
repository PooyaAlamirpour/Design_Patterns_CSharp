using System;
using System.Collections.Generic;
using StrategyPattern.Strategies;

namespace StrategyPattern.ConcreteStrategies
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine($"The list is sorted by {nameof(ShellSort)}");
        }
    }
}