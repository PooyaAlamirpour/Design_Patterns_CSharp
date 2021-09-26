using System;
using ChainOfResponsibility.ConcreteHandlers;
using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new Concretehandler2();
            Handler handler3 = new Concretehandler3();

            handler1.WhenDonePassTo(handler2);
            handler2.WhenDonePassTo(handler3);

            var requests = new[] {2, 5, 14, 22, 18, 3, 27, 20};
            foreach (var request in requests)
            {
                handler1.HandleRequest(request);
            }
        }
    }
}