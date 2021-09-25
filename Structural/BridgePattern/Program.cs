using System;
using BridgePattern.Abstractions;
using BridgePattern.ConcreteImplementors;
using BridgePattern.RefinedAbstractions;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction();
            abstraction.Execute();
            
            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.Execute();
            
            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Execute();
        }
    }
}