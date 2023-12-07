namespace ConsoleApp.Model
{
    // Klasa bazowa
    public abstract class Account
    {
        public string Number;      // pole publiczne (public)
        protected decimal Balance; // pole chronione (protected)

        public decimal GetBalance()
        {
            return Balance;
        }

        public string Currency;

        public DateTime OpenedDate;

        private DateTime? ClosedDate; // pole prywatne (private)

        public void Close()           // Metoda publiczna
        {
            if (CanClose())
            {
                ClosedDate = DateTime.Today;
            }
        }

        // Metoda prywatna - możemy ją wywołać tylko z klasy, którą jest właścicielem tej metody
        // Nie można jest wywołać z obcej klasy lub klasy potomnej
        private bool CanClose()
        {
            return Balance == 0;            
        }

        // Metoda publiczna - można ją wywołać z obcej klasy lub klasy potomnej
        public void Print()
        {
            Console.WriteLine($"{Number} {Balance:N2} {OpenedDate} {Currency}");
        }

        // Metoda chroniona (protected) - można ją wywołać tylko z klasy potomnej, nie można jest wywołać z obcej klasy

        public abstract void Income(decimal amount);  // Metoda abstrakcyjna. Posiada tylko sygnaturę metody bez jej ciała.
        public abstract void Withdraw(decimal amount); // Metoda abstrakcyjna
    }
}
