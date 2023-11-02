using Composite.Model; 

namespace Composite 
{
    public static class Client 
    {
        public static void Execute() 
        {
            ComponentModel product1 = new ProductLeaf("Cup1", 25.00);
            ComponentModel product2 = new ProductLeaf("Cup2", 25.00);    
            ComponentModel product3 = new ProductLeaf("Cup3", 25.00);
            ComponentModel product4 = new ProductLeaf("Cup4", 25.00);
            ComponentModel product5 = new ProductLeaf("Cup5", 500.00);

            ComponentModel smallBox = new ProductComposite();
            smallBox.Add(product1, product2, product3, product4);

            ComponentModel bigBox = new ProductComposite();
            bigBox.Add(smallBox, product5);

            var totalValue = bigBox.Operation();

            Console.WriteLine($"Total value: {totalValue}");
        }
    }
}