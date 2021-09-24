using DecoratorDesignPattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ConcreteComponents
{
    public class ConcreteComponent : Component
    {
        public override void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This is the main responsibility of the component.");
            Console.ResetColor();
        }
    }
}
