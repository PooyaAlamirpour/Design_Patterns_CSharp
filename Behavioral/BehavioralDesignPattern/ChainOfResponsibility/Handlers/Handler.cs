namespace ChainOfResponsibility.Handlers
{
    public abstract class Handler
    {
        protected Handler handler;

        public void WhenDonePassTo(Handler handler)
        {
            this.handler = handler;
        }

        public abstract void HandleRequest(int request);
    }
}