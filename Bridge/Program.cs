using Bridge;
using Bridge.Implementations;
using Bridge.Implementations.Interfaces;
using Bridge.Abstractions;
using Bridge.Abstractions.Interfaces;


while(true)
{
    Console.WriteLine("Select a product:\n1 - Brush\n2 - Pensil");

    int productSelected = int.Parse(Console.ReadLine());

    Console.WriteLine("Select the color of the product:\n1 - Blue\n2 - Gray\n3 - Red");

    int colorSelected = int.Parse(Console.ReadLine());

    IColor colorImplementation = colorSelected switch 
    {
        1 => new Blue(),
        2 => new Gray(),
        3 => new Red()
    };

    IMaterial material = productSelected switch 
    {
        1 => new Brush(),
        2 => new Pensil()
    };

    material.ColorImplementation = colorImplementation;

    Client.Material = material;
    Client.Execute();
     
    Console.WriteLine("Do you want to continue?\n 1 - Yes\n 2 - No");

    if(int.Parse(Console.ReadLine()) == 2)
        break; 
}