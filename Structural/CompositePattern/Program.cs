using System;
using CompositePattern.Composites;
using CompositePattern.leaves;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var compX = new Composite("Composite X");
            compX.Add(new Leaf("Leaf XA"));
            compX.Add(new Leaf("Leaf XB"));
            
            var compY = new Composite("Composite Y");
            compY.Add(new Leaf("Leaf YA"));
            compY.Add(new Leaf("Leaf YB"));
            
            compX.Add(compY);
            root.Add(compX);
            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);
            
            root.Display(1);
        }
    }
}