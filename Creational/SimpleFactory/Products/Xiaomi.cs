using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.ConcreteProduct
{
    public class Xiaomi : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine($"{nameof(Xiaomi)} is created...");
        }
    }
}
