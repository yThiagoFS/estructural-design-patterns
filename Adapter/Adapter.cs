using Adapter.Interfaces; 
using Adapter.LegacyBusiness;

namespace Adapter 
{
    public class Adapter : IAdapter 
    {
        LegacyBusinessHandler _legacy;

        public Adapter(LegacyBusinessHandler legacy)
            => _legacy = legacy;
        
        public string ExecutePaymentRoutine(string month)
            => _legacy.ExecutePaymentRoutine(month);

        public string ExecuteReceivingRoutine(string month)
            => _legacy.ExecuteReceivingRoutine(month);
    }
}