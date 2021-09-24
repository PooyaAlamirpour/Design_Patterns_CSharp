using AdapterPattern.Adaptees;
using AdapterPattern.Targets;

namespace AdapterPattern.Adapters
{
    public class Adapter : Target
    {
        private Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}