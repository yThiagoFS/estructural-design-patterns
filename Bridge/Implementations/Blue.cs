using Bridge.Implementations.Interfaces;

namespace Bridge.Implementations
{
    public class Blue : IColor 
    {
        public string GetColorQuantity(string abstractionType) 
        {
            var random = new Random();
            var quantity = random.Next(1,100);
            return $"There're {quantity} in the sock for {abstractionType} and color blue.";
        }
    }
}