using Bridge.Implementations.Interfaces;

namespace Bridge.Abstractions.Interfaces
{
    public interface IMaterial
    {
        public IColor ColorImplementation { get; set; }

        string CheckStock();
    }
}