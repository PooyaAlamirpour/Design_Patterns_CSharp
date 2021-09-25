using System;
using BridgePattern.Implementors;

namespace BridgePattern.ConcreteImplementors
{
    public class ConcreteImplementorB : Implementor
    {
        public override void Execute()
        {
            Console.WriteLine($"The {nameof(ConcreteImplementorB)} is executed.");
        }
    }
}