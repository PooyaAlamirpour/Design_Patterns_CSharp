using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsystems
{
    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine($"The {nameof(this.MethodTwo)} is launched.");
        }
    }
}
