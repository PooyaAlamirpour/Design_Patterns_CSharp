using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.ConcreteProduct
{
    public class Samsung : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine($"{nameof(Samsung)} is created...");
        }
    }
}
