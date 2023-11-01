using Flyweight.Models;

namespace Flyweight.Flyweights 
{
    public class BlueSpaceShip : SpaceShip
    {
        public BlueSpaceShip()
        {
            Condition = "Flying straight";
            Action = "Firing lasers";
        }

        public override void Show(string color, string size)
        {
            Color = color;
            Size = size;
            Console.WriteLine($"Blue space ship - {Size} - {Color} - {Condition} - {Action}");
        }
    }
}