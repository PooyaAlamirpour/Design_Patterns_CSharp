using BridgePattern.ConcreteImplementors;
using BridgePattern.Implementors;

namespace BridgePattern.Abstractions
{
    public class Abstraction
    {
        protected Implementor implementor;
        public Implementor Implementor {
            set => implementor = value;
        }

        public virtual void Execute() => implementor.Execute();
    }
}