namespace Adapter.Interfaces 
{
    public interface IAdapter 
    {
        string ExecutePaymentRoutine(string month);

        string ExecuteReceivingRoutine(string month);
    }
}