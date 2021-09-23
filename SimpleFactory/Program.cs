using SimpleFactory.Product;
using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Centralized object creatin
            // Enhances scalability and testability of the application
            // Enhances code maintainability
            // Code adheres to SOLID principle

            IMobile mobile = MobileFactory.CreateMobile(BrandType.Samsung);
            mobile.GetMobile();
        }
    }
}
