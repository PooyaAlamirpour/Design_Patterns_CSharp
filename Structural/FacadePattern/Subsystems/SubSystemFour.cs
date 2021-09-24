using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsystems
{
    public class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine($"The {nameof(this.MethodFour)} is launched.");
        }
    }
}
