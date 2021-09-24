using FacadePattern.Facades;
using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.MethodA();

            Console.WriteLine("\n" + new string('-', 20) + "\n");

            facade.MethodB();
        }
    }
}
