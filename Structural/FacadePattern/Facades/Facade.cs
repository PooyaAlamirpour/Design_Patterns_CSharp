using FacadePattern.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Facades
{
    public class Facade
    {
        private SubSystemOne _subSystemOne { get; set; }
        private SubSystemTwo _subSystemTwo { get; set; }
        private SubSystemThree _subSystemThree { get; set; }
        private SubSystemFour _subSystemFour { get; set; }

        public Facade()
        {
            _subSystemOne = new SubSystemOne();
            _subSystemTwo = new SubSystemTwo();
            _subSystemThree = new SubSystemThree();
            _subSystemFour = new SubSystemFour();
        }

        internal void MethodA()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MethodA is launched.");
            Console.ResetColor();

            _subSystemOne.MethodOne();
            _subSystemTwo.MethodTwo();
            _subSystemFour.MethodFour();
        }

        internal void MethodB()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MethodB is launched.");
            Console.ResetColor();

            _subSystemTwo.MethodTwo();
            _subSystemThree.MethodThree();
        }
    }
}
