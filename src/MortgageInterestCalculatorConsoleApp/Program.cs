using System.Globalization;

Console.Write("Podaj kwotę pozostałą do spłaty: ");

decimal leftToPaid;
decimal rate;

if (decimal.TryParse(Console.ReadLine(), out leftToPaid))
{
    Console.WriteLine(leftToPaid);
}
else
{
    Console.WriteLine("Błędna wartość");
}

// 6

Console.Write("Podaj oprocentowanie kredytu, np. 6%: ");

if (decimal.TryParse(Console.ReadLine(), out rate))
{
    rate = rate / 100;
}

// int daysInYear = new JulianCalendar().GetDaysInYear(2023);
int daysInYear = DateTime.IsLeapYear(DateTime.Today.Year) ? 366 : 365;

int daysInMonth = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);

decimal interest = CalculateInterest(leftToPaid, rate, daysInMonth);

string message = interest.ToString("C2", CultureInfo.CreateSpecificCulture("es-ES"));

Console.WriteLine(message);

Console.WriteLine($"Odsetki: {message}");

decimal CalculateInterest(decimal leftToPaid, decimal rate, int daysInMonth, int daysInYear = 365)
{
    return leftToPaid * rate * daysInMonth / daysInYear;
}