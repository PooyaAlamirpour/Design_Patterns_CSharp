using System;
using BridgePattern.Abstractions;

namespace BridgePattern.RefinedAbstractions
{
    public class RefinedAbstraction : Abstraction
    {
        public override void Execute()
        {
            Console.WriteLine($"The {nameof(RefinedAbstraction)} is executed.\n");
            implementor?.Execute();
        }
    }
}