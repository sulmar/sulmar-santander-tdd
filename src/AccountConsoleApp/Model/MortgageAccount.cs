namespace ConsoleApp.Model
{
    // Klasa potomna
    class MortgageAccount : Account
    {      
        public override void Income(decimal amount) // Implementuje metodę abstrakcyjną dlatego override
        {
            this.Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("Wypłata niemożliwa");
            throw new NotSupportedException();
        }
    }
}
