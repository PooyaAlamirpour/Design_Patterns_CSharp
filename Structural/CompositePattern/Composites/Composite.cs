using System;
using System.Collections.Generic;
using CompositePattern.Components;
using CompositePattern.leaves;

namespace CompositePattern.Composites
{
    public class Composite : Component
    {
        private List<ComponentLess> _childeren = new List<ComponentLess>();
        public Composite(string treeName) : base(treeName)
        {
        }

        public override void Add(ComponentLess component)
        {
            _childeren.Add(component);
        }

        public override void Remove(ComponentLess component)
        {
            _childeren.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (var component in _childeren)
            {
                component.Display(depth + 2);
            }
        }
    }
}