using System;
using StrategyPattern.ConcreteStrategies;
using StrategyPattern.Contexts;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameList = new SortedList();
            
            nameList.Add("Samuel");
            nameList.Add("Jimmy");
            nameList.Add("Sandra");
            nameList.Add("Vivek");
            nameList.Add("Anna");

            nameList.SetSortStrategy(new QuickSort());
            nameList.Sort();
            
            nameList.SetSortStrategy(new ShellSort());
            nameList.Sort();
            
            nameList.SetSortStrategy(new MergeSort());
            nameList.Sort();
        }
    }
}