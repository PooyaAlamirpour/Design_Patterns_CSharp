using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    public class XiaomiRedmi6 : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine($"{nameof(XiaomiRedmi6)} is created...");
        }
    }
}