using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    public class SamsungA9 : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine($"{nameof(SamsungA9)} is created...");
        }
    }
}
