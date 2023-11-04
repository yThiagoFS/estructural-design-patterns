using Decorator.Interfaces;

namespace Decorator.Decorators
{
    public class SpaDecorator : PetDecorator
    {
        public SpaDecorator(IPet pet) : base(pet) {}

        public override string GetServiceName()
            => base.GetServiceName() + "\n[+] Spa";

        public override double GetServiceValue()
            => base.GetServiceValue() + 100.00;
    }   
}