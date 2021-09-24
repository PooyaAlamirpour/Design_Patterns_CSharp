using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsystems
{
    public class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine($"The {nameof(this.MethodThree)} is launched.");
        }
    }
}
