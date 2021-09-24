using ProxyPattern.RealSubjects;
using ProxyPattern.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Proxies
{
    public class Proxy : Subject
    {
        private RealSubject realSubject;

        public override void Request()
        {
            if (realSubject is null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}
