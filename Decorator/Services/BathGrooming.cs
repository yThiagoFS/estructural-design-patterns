using Decorator.Interfaces;

namespace Decorator.Services
{
    public class BathGrooming : IPet
    {
        private string _serviceName;
        private double _serviceValue;

        public BathGrooming(string serviceName, double serviceValue)
        {
            _serviceName = serviceName;
            _serviceValue = serviceValue;
        }

        public string GetServiceName()
            => _serviceName;

        public double GetServiceValue()
            => _serviceValue;
    }
}