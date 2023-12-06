namespace ConsoleApp.Model
{
    // Dziedziczenie (Inheritance)
    // Klasa potomna
    class CreditCardAccount : BankingAcount
    {
        public decimal FeeAfterPeriod;

        public CreditCardAccount(string creditCardNumber, decimal feeAfterPeriod, string currency = "PLN")
             : base(creditCardNumber, currency) // Wywołanie konstruktora klasy bazowej
        {
            FeeAfterPeriod = feeAfterPeriod;         
        }

        public new void Income(decimal amount)  // new - tworzymy nową implementację metody z klasy bazowej
        {
            this.Balance -= amount;
        }

        public new void Withdraw(decimal amount)
        {
            this.Balance += amount;
        }

        // Nowa implementacja metody Print z klasy bazowej
        public new void Print()
        {
            // Wywołanie metody Print klasy bazowej 
            base.Print();

            Console.WriteLine($"{FeeAfterPeriod}");
        }

        public decimal CalculateFee()
        {
            return this.Balance * this.FeeAfterPeriod;
        }

    }
}
