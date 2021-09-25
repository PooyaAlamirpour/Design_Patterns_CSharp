namespace CompositePattern.Components
{
    public abstract class ComponentLess
    {
        protected string name;
        
        protected ComponentLess(string name)
        {
            this.name = name;
        }
        public abstract void Display(int depth);

    }
}