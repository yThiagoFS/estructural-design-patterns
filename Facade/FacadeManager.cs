using Facade.ComplexEnvironments; 

namespace Facade 
{
    public class FacadeManager 
    {
        public void ExecuteComplexity() 
        {
            South south = new();
            North north = new();
            CloudComputing cloud = new();

            var southLoss = south.ExecuteLostSalesRoutine(DateTime.Now);
            var northLoss = north.ExecuteLostSalesRoutine(DateTime.Now);

            cloud.GenerateLossWinsReport(southLoss, northLoss);
        }
    }
}