using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class CustomerOrder
    {
        private readonly Logger _logger;

        public CustomerOrder()
        {
            _logger = Logger.getInstance;
        }

        public void PlaceOrder(int orderNumber)
        {
            _logger.LogInfo($"Order number of {orderNumber} is done.");
        }
    }
}
