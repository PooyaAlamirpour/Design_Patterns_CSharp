using System;
using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility.ConcreteHandlers
{
    public class Concretehandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request is >= 10 and < 20)
            {
                Console.WriteLine($"{this.GetType().Name} handled request of {request}");
            }

            handler?.HandleRequest(request);
        }
    }
}