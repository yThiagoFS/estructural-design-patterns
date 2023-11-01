using Flyweight.Models;

namespace Flyweight.Flyweights 
{
    public class GraySpaceShip : SpaceShip
    {
        public GraySpaceShip()
        {
            Condition = "Flying straight";
            Action = "Firing lasers";
        }

        public override void Show(string color, string size)
        {
            Color = color;
            Size = size;
            Console.WriteLine($"Gray space ship - {Size} - {Color} - {Condition} - {Action}");
        }
    }
}