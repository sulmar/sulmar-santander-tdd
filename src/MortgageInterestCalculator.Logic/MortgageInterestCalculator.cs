using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Logic
{
    // Abstracja 
    // https://learn.microsoft.com/pl-pl/dotnet/core/whats-new/dotnet-8#time-abstraction
    public class MortgageInterestCalculator
    {
        private DateTime currentDate;

        public MortgageInterestCalculator()
            : this(DateTime.Today)
        {            
        }

        public MortgageInterestCalculator(DateTime currentDate)
        {
            this.currentDate = currentDate;
        }

        public decimal Calculate(decimal leftToPaid, decimal rate)
        {
            if (leftToPaid == 0)
                throw new InvalidOperationException(); // w danym stanie obiektu ta operacja nie ma sensu

            if (leftToPaid < 0) 
                throw new ApplicationException(); // błąd aplikacji 

            if (rate < 0)
                throw new ArgumentOutOfRangeException(); // argument wykracza poza zakres
            
            rate = rate / 100;

            int daysInYear = DateTime.IsLeapYear(currentDate.Year) ? 366 : 365;
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            decimal interest = Math.Round(leftToPaid * rate * daysInMonth / daysInYear, 0);

            return interest;
        }
    }
}
