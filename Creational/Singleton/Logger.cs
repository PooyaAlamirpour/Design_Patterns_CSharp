using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Logger
    {
        private static Logger _instance;
        private static readonly object _lockObject = new object();

        private Logger()
        {
            Console.WriteLine("A new instance of class is created.");
        }

        public static Logger getInstance { 
            get
            {
                if (_instance == null)                  // For improving performance
                {
                    lock (_lockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            } 
        }

        public void LogInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
