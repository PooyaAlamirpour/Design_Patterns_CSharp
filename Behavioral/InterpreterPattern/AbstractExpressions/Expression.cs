using InterpreterPattern.Contexts;

namespace InterpreterPattern.AbstractExpressions
{
    public abstract class Expression
    {
        protected abstract string One();
        protected abstract string Four();
        protected abstract string Five();
        protected abstract string Nine();
        protected abstract int Multiplier();
        
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;
            if (context.Input.StartsWith(Nine()))
            {
                context.Output += (9 * Multiplier());
                context.Input = context.Input[2..];
            }
            else if (context.Input.StartsWith(Four()))
            {
                context.Output += (4 * Multiplier());
                context.Input = context.Input[2..];
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.Output += (5 * Multiplier());
                context.Input = context.Input[1..];
            }
            while (context.Input.StartsWith(One()))
            {
                context.Output += (1 * Multiplier());
                context.Input = context.Input[1..];
            }
        }
    }
}