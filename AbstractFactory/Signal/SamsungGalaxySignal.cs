using AbstractFactory.ProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Signal
{
    public class SamsungGalaxySignal : ISignal
    {
        public void showSignalStrength()
        {
            Console.WriteLine($"{nameof(SamsungGalaxySignal)} is good");
        }
    }
}
