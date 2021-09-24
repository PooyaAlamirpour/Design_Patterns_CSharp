using DecoratorDesignPattern.Components;
using DecoratorDesignPattern.ConcreteComponents;
using DecoratorDesignPattern.ConcreteDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorators
{
    public class Decorator : Component
    {
        protected Component component;

        public override void Execute()
        {
            if(component is not null)
            {
                component.Execute();
            }
        }

        public void SetComponent(Component component)
        {
            this.component = component;
        }
    }
}
