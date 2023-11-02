using Bridge.Abstractions.Interfaces;
using Bridge.Implementations.Interfaces;

namespace Bridge.Abstractions 
{
    public class Pensil : IMaterial
    {
        public IColor ColorImplementation { get; set; }

        public string CheckStock()
            => ColorImplementation.GetColorQuantity("Pensil");
    }
}