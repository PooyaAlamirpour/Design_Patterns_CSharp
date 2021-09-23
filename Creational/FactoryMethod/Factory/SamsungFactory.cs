using FactoryMethod.FactoryInterfaces;
using FactoryMethod.Products;
using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class SamsungFactory : IMobileFactory
    {
        public IMobile GetMobile(ModelType modelType) => modelType switch
        {
            ModelType.Galaxy => new SamsungGalaxy(),
            ModelType.A9 => new SamsungA9(),
            _ => throw new Exception("Invalid mode type is required.")
        };
    }
}
