using Adapter.Interfaces;
using Adapter.LegacyBusiness;
using System.Threading;

namespace Adapter 
{
    public class CloudComputing 
    {
        IAdapter _adapter;

        public CloudComputing() 
            => _adapter = new Adapter(new LegacyBusinessHandler());

        public void ProccessBills(string month)
        {
            var paymentResult = _adapter.ExecutePaymentRoutine(month);

            Console.WriteLine("Processing payment routine...- Cloud Computing");

            Thread.Sleep(3000);

            var receivingResult = _adapter.ExecuteReceivingRoutine(month);

            Console.WriteLine("Processing receiving routine...- Cloud Computing");
        }
    }
}