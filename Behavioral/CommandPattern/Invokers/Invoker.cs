using CommandPattern.Commands;

namespace CommandPattern.Invokers
{
    public class Invoker
    {
        private Command _command;
        public void SetCommand(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            this._command.Execute();
        }
    }
}