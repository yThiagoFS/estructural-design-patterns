using Bridge.Abstractions.Interfaces;
using Bridge.Implementations.Interfaces;

namespace Bridge.Abstractions 
{
    public class Brush : IMaterial 
    {
        public IColor ColorImplementation { get; set; }

        public string CheckStock()
            => ColorImplementation.GetColorQuantity("Brush");
    }
}