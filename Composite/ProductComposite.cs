using Composite.Model;

namespace Composite 
{
    public class ProductComposite: ComponentModel 
    {
        List<ComponentModel> _components;
        
        public ProductComposite()
            => _components = new List<ComponentModel>();

        public override double Operation() 
        {
            double totalValue = 0;

            for(int i = 0; i < _components.Count; i++) 
            {
                var component = _components[i];
                var child = component.GetChild(i);
                totalValue += component.Operation();
            }

            return totalValue;
        }

        public override void Add(params ComponentModel[] components)
            => _components.AddRange(components);  

        public override void Remove(ComponentModel component)
            => _components.Remove(component);

        public override ComponentModel GetChild(int index)
        {
            if(_components.Count == 0)
            {
                Console.WriteLine("There's no component added.");
                return null;
            }
            else 
            {
                return _components[index];
            }
        }
    }
}