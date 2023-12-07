using App.Logic;

namespace MortgageInterestCalculatorWinFormsApp.Model
{

    internal class FrmMainModel : FrmBaseModel
    {
        MortgageInterestCalculator calculator = new MortgageInterestCalculator();

        // Właściwości
        public decimal LeftToPaid { get; set; }
        public decimal Rate { get; set; }

        // Pole prywatne
        private decimal _interest;

        // Właściwość
        public decimal Interest 
        {  
            get
            {
                return _interest;
            }
            set
            {
                _interest = value;

                // Dobra praktyka - po ustawieniu wartości właściwości
                OnPropertyChanged(nameof(Interest));
            }
        }

        public FrmMainModel()
        {
            LeftToPaid = 1000;
            Rate = 0.6m;            
        }

        public void CalculateInterest()
        {
            Interest = calculator.Calculate(LeftToPaid, Rate);

            // Zła praktyka 
            //OnPropertyChanged("Interest");            
        }

        public void CalculateDiscount()
        {
            Interest -= 10;

            // Zła praktyka 
            //OnPropertyChanged("Interest");
        }

        // Właściwość

        public bool CanCalculateInterest
        {
            get
            {
                return LeftToPaid > 0 && Rate > 0;
            }
        }
        
        public bool ShowEmoji
        {
            get
            {
                return Interest > 0;
            }
            
        }
    }
}
