// See https://aka.ms/new-console-template for more information
using BankingAccounts.Model;

Console.WriteLine("Hello, World!");

Bike bike = new Bike();

bike.Color = "red";
Console.WriteLine(bike.Color);

bike.Color = "magenta";
Console.WriteLine(bike.Color);

Person.AdultAge = 18;

Person person1 = new Person("11111") { FirstName = "John", LastName = "Smith" };
Person person2 = new Person("22222") { FirstName = "Kate", LastName = "Smith" };

Console.WriteLine(person1.FullName);

// Pola statyczne nie wymagają tworzenia instancji obiektu
Console.WriteLine(BankingAccount.MaximumDebit);

BankingAccount account = new BankingAccount();

Console.WriteLine(account.ClosedDate);

account.Currency = "PLN"; // wywołanie settera
string currency = account.Currency; // wywołanie gettera

// account.Number = "00 0000 0000 0000 0000 0000 0000";

account.Number = "00 0000 0000 0000 0000 0000 0000";



Console.WriteLine(account.Number);

account.Income(100);

account.Withdraw(200);

Console.WriteLine(account.GetBalance());