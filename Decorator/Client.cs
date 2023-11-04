using Decorator.Decorators;
using Decorator.Interfaces;
using Decorator.Services;

namespace Decorator 
{
    public static class Client
    {
        public static void Execute() 
        {
            IPet bathGrooming = new BathGrooming("Bath and grooming", 45.00);

            IPet spaDecorator = new SpaDecorator(bathGrooming);

            IPet acessoryDecorator = new AcessoryDecorator(spaDecorator);

            Console.WriteLine($"Bath Grooming service: {bathGrooming.GetServiceName()}, value: {bathGrooming.GetServiceValue()}");

            Console.WriteLine($"Spa decorator service: {spaDecorator.GetServiceName()}, value: {spaDecorator.GetServiceValue()}");

            Console.WriteLine($"Acessory decorator service: {acessoryDecorator.GetServiceName()}, value: {acessoryDecorator.GetServiceValue()}");
        }
    }
}