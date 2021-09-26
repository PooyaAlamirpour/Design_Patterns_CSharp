using System;
using MediatorPattern.ConcreteMediators;

namespace MediatorPattern.Colleagues
{
    public class Participant
    {
        public Participant(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public Chatroom Chatroom { get; set; }

        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }
        
        public void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {Name}: {message}");
        }
    }
}