using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FactoryInterfaces
{
    public interface IMobileFactory
    {
        IMobile GetMobile(ModelType modelType);
    }
}
