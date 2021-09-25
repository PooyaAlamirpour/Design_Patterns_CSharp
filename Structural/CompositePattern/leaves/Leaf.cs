using System;
using CompositePattern.Components;

namespace CompositePattern.leaves
{
    public class Leaf : ComponentLess
    {
        public Leaf(string leafName) : base(leafName)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

    }
}