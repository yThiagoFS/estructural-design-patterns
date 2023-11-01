namespace Flyweight.Models
{
    public abstract class SpaceShip 
    {
        protected string Condition;
        protected string Action;

        public string Color { get; set; }

        public string Size { get; set; }

        public abstract void Show(string color, string size);
    }
}