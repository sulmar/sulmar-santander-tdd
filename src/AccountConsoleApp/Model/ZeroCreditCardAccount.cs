namespace ConsoleApp.Model
{
    class ZeroCreditCardAccount : CreditCardAccount
    {
        public ZeroCreditCardAccount(string creditCardNumber, decimal feeAfterPeriod, string currency = "PLN") : base(creditCardNumber, feeAfterPeriod, currency)
        {
            
        }

        public void OdroczenieSplaty()
        {

        }        
    }
}
