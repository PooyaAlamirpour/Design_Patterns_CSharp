using FactoryMethod.Factory;
using FactoryMethod.FactoryInterfaces;
using SimpleFactory.Product;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client is unaware of object instantiation logic
            // Encapsulated the instantiation logic
            // Helps in application scalability
            // Code maintainability

            IMobileFactory mobileFactory = new XiaomiFactory();
            IMobile mobile = mobileFactory.GetMobile(ModelType.RedmiPro);
            mobile.GetMobile();
			
			Console.ReadKey();
        }
    }
}
