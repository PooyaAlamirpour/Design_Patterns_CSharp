using FactoryMethod;
using FactoryMethod.Factory;
using FactoryMethod.FactoryInterfaces;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hides construction of related objects
            // Encapsulates a group of indivusal factories
            // Promotes consistency among products

            IMobileFactory mobileFactory = new XiaomiFactory();
            mobileFactory.GetMobile(ModelType.RedmiPro).GetMobile();
            mobileFactory.GetSignalStrength(ModelType.RedmiPro).showSignalStrength();
        }
    }
}
