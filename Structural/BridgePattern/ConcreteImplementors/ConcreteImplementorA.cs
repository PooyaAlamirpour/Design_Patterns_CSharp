using System;
using BridgePattern.Implementors;

namespace BridgePattern.ConcreteImplementors
{
    public class ConcreteImplementorA : Implementor
    {
        public override void Execute()
        {
            Console.WriteLine($"The {nameof(ConcreteImplementorA)} is executed.");
        }
    }
}