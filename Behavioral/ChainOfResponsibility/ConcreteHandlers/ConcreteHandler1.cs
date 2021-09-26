using System;
using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility.ConcreteHandlers
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request is >= 0 and < 10)
            {
                Console.WriteLine($"{this.GetType().Name} handled request of {request}");
            }

            handler?.HandleRequest(request);
        }
    }
}