using Flyweight;
using Flyweight.Models;

namespace Flyweight 
{
    public static class Client
    {
        static List<string> colorsAndSizes = new() 
        {
            "blue:small",
            "gray:medium",
            "red:big",
            "blue:small",
            "gray:medium",
            "red:big"
        };

        public static void ConsumeFlyweights()
        {
            var flyweightFactory = new FlyweightFactory();

            foreach(var colorsAndSize in colorsAndSizes)
            {
                var color = colorsAndSize.Split(":")[0];
                var size = colorsAndSize.Split(":")[1];
                var spaceShip = flyweightFactory.GetShip(color);
                spaceShip.Show(color, size);
            }
        }
    }
}