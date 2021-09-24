using ProxyPattern.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.RealSubjects
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("The request of real object is called.");
        }
    }
}
