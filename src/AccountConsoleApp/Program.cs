using ConsoleApp.Model;

namespace ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Account bankingAcount = new BankingAcount("111100000");
            Account creditCardAccount = new CreditCardAccount("222200000", 0.01m);

            creditCardAccount.Withdraw(1000);

            bankingAcount.Print();

            creditCardAccount.Print();

            bankingAcount.Close();                                   

            

            creditCardAccount.Close();


            //this.OpenedDate = DateTime.Today.AddDays(1);
            //base.OpenedDate = DateTime.Today.AddDays(-1);





            bankingAcount.Income(100);

            bankingAcount.Withdraw(20);
            creditCardAccount.Income(20);

            creditCardAccount.Withdraw(20);

            bankingAcount.Print();
            creditCardAccount.Print();
        }
    }
}
