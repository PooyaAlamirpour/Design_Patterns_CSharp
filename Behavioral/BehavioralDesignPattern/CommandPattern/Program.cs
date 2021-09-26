using System;
using CommandPattern.Commands;
using CommandPattern.ConcreteCommands;
using CommandPattern.Invokers;
using CommandPattern.Receivers;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var receiver = new Receiver();
            var invoker = new Invoker();

            Command command = new ConcreteCommand();
            command.SetReceiver(receiver);

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}