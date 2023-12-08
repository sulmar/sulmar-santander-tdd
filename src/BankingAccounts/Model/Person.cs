namespace BankingAccounts.Model;

internal class Person
{
    public Person(string pesel)
    {
        this.Pesel = pesel;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }

    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    // Właściwość tylko do odczytu z zastosowaniem metody
    public string FullAddress2
    {
        get
        {
            return $"{Address} {City} {Country}";
        }
    }

    // Właściwość tylko do odczytu z zastosowaniem wyrażenia lambda
    public string FullAddress => $"{Address} {City} {Country}";

    // public string Property { get; } - właściwość tylko do odczytu, można go ustawić tylko w konstruktorze lub wyznaczyć za pomocą funkcji
    // public string Property { get; private set; } - właściwość do odczytu i możliwość ustawiania z wnętrza klasy
    // public string Property { get; set; } - właściwość do odczytu i możliwość ustawiania z spoza klasy

    // właściwość tylko do odczytu, ustawiania za pomocą konstruktora
    public string Pesel { get; }
    public byte Age { get; set; }

    // Pole statyczne - atrybut klasy a nie konkretnego obiektu
    public static byte AdultAge { get; set; }

    // właściwość tylko do odczytu, wartość wyznaczana za pomocą funkcji
    public bool IsAdult
    {
        get
        {
            return Age > AdultAge;
        }
    }

}
