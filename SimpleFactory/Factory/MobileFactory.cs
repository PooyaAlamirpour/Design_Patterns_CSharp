using SimpleFactory.ConcreteProduct;
using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class MobileFactory
    {
        public static IMobile CreateMobile(BrandType brandType) => brandType switch
        {
            BrandType.Samsung => new Samsung(),
            BrandType.Xiaomi => new Xiaomi(),
            _ => throw new Exception("Invalid brand type.")
        };
    }
}
