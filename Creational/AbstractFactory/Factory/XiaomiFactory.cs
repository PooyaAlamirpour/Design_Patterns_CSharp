using AbstractFactory.ProductInterfaces;
using AbstractFactory.Signal;
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
    public class XiaomiFactory : IMobileFactory
    {
        public IMobile GetMobile(ModelType modelType) => modelType switch
        {
            ModelType.Redmi6 => new XiaomiRedmi6(),
            ModelType.RedmiPro => new XiaomiRedmiPro(),
            _ => throw new Exception("Invalid model type is required.")
        };

        public ISignal GetSignalStrength(ModelType modelType) => modelType switch
        {
            ModelType.RedmiPro => new XiaomiRedmiProSignal(),
            _ => throw new Exception("Invalid model type is required.")
        };
    }
}
