using MediatorPattern.Colleagues;

namespace MediatorPattern.ConcreteColleagues
{
    public class Beatle : Participant
    {
        private readonly string _name;

        public Beatle(string name) : base(name)
        {
            this._name = name;
        }
        
    }
}