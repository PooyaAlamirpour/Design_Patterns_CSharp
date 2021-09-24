using DecoratorDesignPattern.ConcreteComponents;
using DecoratorDesignPattern.ConcreteDecorators;
using System;
using System.Collections.Generic;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Decorator is a design pattern which is used for attaching additional responsibilities to an object dynamically.

            ConcreteComponent component = new ConcreteComponent();

            ConcreteDecoratorA oncreteDecoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB oncreteDecoratorB = new ConcreteDecoratorB();

            oncreteDecoratorA.SetComponent(component);
            oncreteDecoratorA.Execute();

            Console.WriteLine(new string('-', 20));

            oncreteDecoratorB.SetComponent(component);
            oncreteDecoratorB.Execute();

            Console.WriteLine(new string('-', 20));

            oncreteDecoratorB.SetComponent(oncreteDecoratorA);
            oncreteDecoratorB.Execute();

            Console.WriteLine(new string('-', 20));
        }
    }
}
