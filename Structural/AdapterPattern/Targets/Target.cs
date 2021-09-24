using System;

namespace AdapterPattern.Targets
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("The target request is called.");
        }
    }
}