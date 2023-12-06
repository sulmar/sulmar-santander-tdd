using System.Drawing;

namespace ConsoleApp.Model
{

    // Klasa potomna
    class BankingAcount : Account
    {
        public BankingAcount(string number, string currency = "PLN")
        {
            Number = number;            
            Currency = currency;

            Balance = 0;
            OpenedDate = DateTime.Today;

        }

        public override void Income(decimal amount) // override - tworzymy implementację metody abstrakcyjnej z klasy bazowej
        {
            this.Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new InvalidOperationException();
            }

            this.Balance -= amount;
        }
    }
}
