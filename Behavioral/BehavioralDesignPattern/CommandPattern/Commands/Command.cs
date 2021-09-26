using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    public abstract class Command
    {
        protected Receiver receiver;

        public void SetReceiver(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}