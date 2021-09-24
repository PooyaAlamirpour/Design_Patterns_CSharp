using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsystems
{
    public class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine($"The {nameof(this.MethodOne)} is launched.");
        }
    }
}
