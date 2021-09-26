using System;
using MementoPattern.Originators;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var salesProspect = new SalesProspect
            {
                Name = "Name one",
                Phone = "(555) 456-0997",
                Budget = 1000.0
            };

            var memory = new ProspectMemory
            {
                Memento = salesProspect.SaveMemento()
            };

            salesProspect.Name = "Name two";
            salesProspect.Phone = "(555) 123-1047";
            salesProspect.Budget = 1500.0;

            salesProspect.RestoreMemento(memory.Memento);
        }
    }
}