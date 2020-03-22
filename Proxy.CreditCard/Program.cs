namespace Proxy.CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountChargeTests();
            Logging.LineSeparator();
            OverchargeTests();
        }

        internal static void AccountChargeTests()
        {
            // Create new debit card proxy instance.
            var debitCard = new DebitCard();
            // Attempt two successful charges.
            debitCard.ChargeAccount(125.50M);
            debitCard.ChargeAccount(500);
            // Attempt overcharge.
            debitCard.ChargeAccount(432.10M);
        }

        internal static void OverchargeTests()
        {
            // Create new credit card proxy instance and allow overcharges.
            var creditCard = new CreditCard(); 
            // Attempt two successful charges.
            creditCard.ChargeAccount(125.50M);
            creditCard.ChargeAccount(500); 
            // Attempt overcharge.
            creditCard.ChargeAccount(432.10M);
        }
    }
}