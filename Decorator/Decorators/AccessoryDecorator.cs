using Decorator.Interfaces;

namespace Decorator.Decorators 
{
    public class AcessoryDecorator : PetDecorator 
    {
        public AcessoryDecorator(IPet pet) : base(pet)
        {}

        public override string GetServiceName()
            => base.GetServiceValue() + "\n[+] Acessory";

        public override double GetServiceValue()
            => base.GetServiceValue() + 30.00;
    }
}