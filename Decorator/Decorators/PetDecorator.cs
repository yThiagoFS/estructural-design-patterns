using Decorator.Interfaces;

namespace Decorator.Decorators 
{
    public abstract class PetDecorator : IPet 
    {
        protected IPet _pet { get; set; }

        public PetDecorator(IPet pet)
            => _pet = pet;

        public virtual string GetServiceName()
            => _pet.GetServiceName();

        public virtual double GetServiceValue()
            => _pet.GetServiceValue();
    }
}