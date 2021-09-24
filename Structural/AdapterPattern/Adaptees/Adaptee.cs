using System;

namespace AdapterPattern.Adaptees
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("The specific request is called.");
        }
    }
}