using Flyweight.Models;
using Flyweight.Flyweights;

namespace Flyweight
{
    public class FlyweightFactory 
    {
        Dictionary<string, SpaceShip> spaceShips = new();

        public SpaceShip GetShip(string color)
            => 
                spaceShips.ContainsKey(color) 
                ? spaceShips[color] 
                : AddShip(color);

        public SpaceShip AddShip(string color)
            => spaceShips[color] = color.ToLower() switch 
            {
                "blue" => new BlueSpaceShip(),
                "red" => new RedSpaceShip(),
                "gray" => new GraySpaceShip()
            };
    }
}