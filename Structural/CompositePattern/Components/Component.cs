namespace CompositePattern.Components
{
    public abstract class Component : ComponentLess
    {
        protected string name;

        protected Component(string name) : base(name)
        {
            this.name = name;
        }
        public abstract void Add(ComponentLess component);
        public abstract void Remove(ComponentLess component);

    }
}