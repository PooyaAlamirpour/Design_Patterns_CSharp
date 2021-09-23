using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    public class SamsungGalaxy : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine($"{nameof(SamsungGalaxy)} is created...");
        }
    }
}
