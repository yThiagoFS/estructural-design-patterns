namespace Adapter.LegacyBusiness 
{
    public class LegacyBusinessHandler 
    {
        public string ExecutePaymentRoutine(string month)
        {
            var result = SQLAccess.GetPaymentData(month);
            Console.WriteLine(result);
            return result;
        }
            

        public string ExecuteReceivingRoutine(string month)
        {
            var result = SQLAccess.GetPaymentData(month);
            Console.WriteLine(result);
            return result;
        }
    }

    public static class SQLAccess 
    {
        public static string GetPaymentData(string month)
            => GetData()[month];

        public static string GetReceivingData(string month)
            => GetData()[month];

        static Dictionary<string, string> GetData()
            => new Dictionary<string, string>() 
            {
                { "June", "June\nCNPJ: 0123456789012\nCompany Name: SomeStore1\nValue: 1200.00\nContact: (xx) 000-000-000" },
                { "July", "July\nCNPJ: 0123456789012\nCompany Name: SomeStore2\nValue: 1200.00\nContact: (xx) 000-000-000" },
                { "August", "August\nCNPJ: 0123456789012\nCompany Name: SomeStore3\nValue: 1200.00\nContact: (xx) 000-000-000" },
                { "September", "September\nCNPJ: 0123456789012\nCompany Name: SomeStore4\nValue: 1200.00\nContact: (xx) 000-000-000" },
                { "October", "October\nCNPJ: 0123456789012\nCompany Name: SomeStore5\nValue: 1200.00\nContact: (xx) 000-000-000" }
            };
    }
}