using Composite.Model;

namespace Composite 
{
    public class ProductLeaf : ComponentModel 
    {
        private string _product { get; set; }    
        private double _value { get; set; }

        public ProductLeaf(string product, double value)
        {
            _product = product;
            _value = value;
        }

        public override double Operation()
        {
            Console.WriteLine($"Product: {_product}\nValue: {_value.ToString("C")}");      
            return _value;      
        }

        public override void Add(params ComponentModel[]components) 
        {
            Console.WriteLine("Its not possible to add objects to a leaf");
        }

        public override void Remove(ComponentModel component)
        {
            Console.WriteLine("Its not possible to remove objects to a leaf");
        }

        public override ComponentModel GetChild(int index)
        {
            Console.WriteLine("Its not possible to get childs in a leaf");
            return null!;
        }
    }
}