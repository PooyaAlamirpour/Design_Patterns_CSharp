using System;
using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility.ConcreteHandlers
{
    public class Concretehandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request is >= 20 and < 30)
            {
                Console.WriteLine($"{this.GetType().Name} handled request of {request}");
            }
            
            handler?.HandleRequest(request);
        }
    }
}