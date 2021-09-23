using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    public class XiaomiRedmiPro : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine($"{nameof(XiaomiRedmiPro)} is created...");
        }
    }
}