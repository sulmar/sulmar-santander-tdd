namespace BankingAccounts.Model;

class Bike
{
    private readonly string[] pallete = new string[] { "blue", "red", "green" };

    // głównym celem właściwości jest ochrona danych i kontrola nad tym w jaki sposób jest coś ustawiane lub pobierane

    // public string Color;
    private string color;
    public string Color
    {
        get { return color; }
        set
        {
            if (pallete.Contains(value))
                color = value;
            else
                color = pallete.First();
        }
    }


}
