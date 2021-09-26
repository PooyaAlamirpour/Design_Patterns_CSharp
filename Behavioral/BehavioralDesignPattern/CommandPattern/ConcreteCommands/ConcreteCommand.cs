using CommandPattern.Commands;

namespace CommandPattern.ConcreteCommands
{
    public class ConcreteCommand : Command
    {
        public override void Execute()
        {
            this.receiver.Action();
        }
    }
}