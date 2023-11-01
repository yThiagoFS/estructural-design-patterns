using Flyweight.Models;

namespace Flyweight.Flyweights 
{
    public class RedSpaceShip : SpaceShip
    {
        public RedSpaceShip()
        {
            Condition = "Flying straight";
            Action = "Firing lasers";
        }

        public override void Show(string color, string size)
        {
            Color = color;
            Size = size;
            Console.WriteLine($"Red space ship - {Size} - {Color} - {Condition} - {Action}");
        }
    }
}