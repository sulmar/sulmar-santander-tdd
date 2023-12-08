namespace BankingAccounts.Model;

internal class BankingAccount
{
    // Zła praktyka: Pola są wystawione jako publiczne

    // Dobra praktyka: Pola publiczne powinny być właściwościami.

    // Stała - ustawiane w trakcie kompilacji aplikacji, tej wartości nie można zmienić
    public const decimal MaximumDebit = -1000;

    // Skrócony zapis
    public string Currency { get; set; }

    /* Rozwijany do postaci
    private string currency; // pole ukryte (backfield)
    public string Currency
    {
        get
        {
            return currency;
        }
        set
        {
            currency = value;
        }
    }
    */

    // Ustawiamy jednorazowo w trakcie działania aplikacji, tej wartości nie można już później zmienić
    public readonly DateTime OpenedDate = DateTime.Now;

    // Właściwość tylko do odczytu
    public bool IsClosed
    {
        get
        {
            return ClosedDate.HasValue;
        }
    }

    // Właściwość do odczytu i możliwość ustawiania tylko przez właściciela
    public DateTime? ClosedDate { get; private set; }

    public void Close()
    {
        if (CanClose())
        {
            ClosedDate = DateTime.Today;
        }
    }

    private bool CanClose()
    {
        return Balance == 0;
    }


    private string number;

    public string Number
    {
        // Getter 
        get
        {
            return number;
        }

        // Setter
        set
        {
            // Walidacja
            if (value.Length != 32)
            {
                throw new FormatException("Konto bankowe w złym formacie");
            }

            this.number = value;

            // Powiadamianie o zmianie wartości (np. INotifyPropertyChanged)
        }
    }



    /*
     
    // Getter
    public string GetNumber()
    {
        return number;
    }

    // Setter
    public void SetNumber(string value)
    {
        if (value.Length != 32)
        {
            throw new FormatException("Konto bankowe w złym formacie");
        }

        this.number = value;
    }

    */

    private decimal Balance;

    public decimal GetBalance()
    {
        return Balance;
    }

    public void Income(decimal amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > this.Balance - MaximumDebit)
        {
            throw new InvalidOperationException();
        }

        Balance -= amount;
    }
}
