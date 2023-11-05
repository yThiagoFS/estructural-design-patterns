namespace Facade.ComplexEnvironments 
{
    public class CloudComputing 
    {
        public void GenerateLossWinsReport(List<object> south, List<object> north) 
        {
            Console.WriteLine("Crossing items stored in the cloud from south and north regions");

            Thread.Sleep(200);
            Console.WriteLine("Wins and loss report completed");
        }
    }
}