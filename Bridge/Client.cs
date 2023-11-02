using Bridge.Abstractions.Interfaces;

namespace Bridge 
{
    public static class Client 
    {
        public static IMaterial Material { get; set; }

        public static void Execute()
        {
            Console.WriteLine(Material.CheckStock());
        }
    }
}