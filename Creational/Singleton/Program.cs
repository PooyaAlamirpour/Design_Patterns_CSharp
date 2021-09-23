using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                CustomerOrder order_1 = new CustomerOrder();
                order_1.PlaceOrder(10);
            }).Start();

            new Thread(() =>
            {
                CustomerOrder order_2 = new CustomerOrder();
                order_2.PlaceOrder(20);
            }).Start();

            new Thread(() =>
            {
                CustomerOrder order_3 = new CustomerOrder();
                order_3.PlaceOrder(30);
            }).Start();
        }
    }
}
