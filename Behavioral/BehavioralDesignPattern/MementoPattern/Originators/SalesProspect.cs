using System;
using MementoPattern.Mementos;

namespace MementoPattern.Originators
{
    public class SalesProspect
    {
        private string _name;
        private string _phone;
        private double _budget;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Console.WriteLine($"Name:   {_name}");
            }
        }
        
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                Console.WriteLine($"Phone:   {_phone}");
            }
        }
        
        public double Budget
        {
            get => _budget;
            set
            {
                _budget = value;
                Console.WriteLine($"Budget:   {_budget}");
            }
        }

        public Memento SaveMemento()
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Saving state.");
            return new Memento(_name, _phone, _budget);
        }

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Restoring state.");
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
        }
    }
}