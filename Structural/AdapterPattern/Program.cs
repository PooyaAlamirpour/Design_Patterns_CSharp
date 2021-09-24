using System;
using AdapterPattern.Adaptees;
using AdapterPattern.Adapters;
using AdapterPattern.Targets;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();
        }
    }
}