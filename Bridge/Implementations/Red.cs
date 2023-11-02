using Bridge.Implementations.Interfaces;

namespace Bridge.Implementations
{
    public class Red : IColor 
    {
        public string GetColorQuantity(string abstractionType) 
        {
            var random = new Random();
            var quantity = random.Next(1,100);
            return $"There're {quantity} {abstractionType} in the stock for color red.";
        }
    }
}