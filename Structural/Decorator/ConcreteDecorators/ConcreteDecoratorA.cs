using DecoratorDesignPattern.ConcreteComponents;
using DecoratorDesignPattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ConcreteDecorators
{
    public class ConcreteDecoratorA : Decorator
    {
        public override void Execute()
        {
            base.Execute();
            runExtraBehavior();
        }

        private void runExtraBehavior()
        {
            Console.WriteLine($"This is responsibility of the {nameof(ConcreteDecoratorA)}.");
        }
    }
}
