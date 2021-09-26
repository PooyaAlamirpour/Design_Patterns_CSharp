using System;
using MediatorPattern.ConcreteColleagues;
using MediatorPattern.ConcreteMediators;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatroom = new Chatroom();

            var George = new Beatle("George");
            var Paul = new Beatle("Paul");
            var Ringo = new Beatle("Ringo");
            var John = new Beatle("John");
            var Yoko = new NonBeatle("Yoko");
            
            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);
            
            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");
        }
    }
}