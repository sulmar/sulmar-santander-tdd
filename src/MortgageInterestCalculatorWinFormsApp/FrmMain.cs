using MortgageInterestCalculatorWinFormsApp.Model;

namespace MortgageInterestCalculatorWinFormsApp
{
    public partial class FrmMain : Form
    {
        FrmMainModel model = new FrmMainModel();

        public FrmMain()
        {
            InitializeComponent();

            // tLeftToPaid.DataBindings.Add("Text", )

            // Automatyczne powi�zanie kontrolek (dwustronne) kontrolka <-> obiekt

            // kontrolka -> obiekt (w pe�ni automatyczne) 
            // To co wprowadzi u�ytkownik do kontrolki jest przenoszone do w�a�ciwo�ci obiektu

            // obiekt -> kontrolka (wymagana jest zdarzenie PropertyChanged interfejsu INotifyPropertyChanged
            // W�a�ciwo�ci obiektu przenoszone s� do kontrolki i kontrolka jest od�wie�ana (Refresh)

            // DataBinding - powi�zanie kontrolki z w�a�ciwo�ci� obiektu
            nLeftToPaid.DataBindings.Add("Value", model, "LeftToPaid", false, DataSourceUpdateMode.OnPropertyChanged);
            tLeftToPaid.DataBindings.Add("Text", model, "LeftToPaid", false, DataSourceUpdateMode.OnPropertyChanged);

            tRate.DataBindings.Add("Text", model, "Rate", false, DataSourceUpdateMode.OnPropertyChanged);
            tIntereset.DataBindings.Add("Text", model, "Interest");

            lEmoji.DataBindings.Add("Visible", model, "ShowEmoji");
            lInterest.DataBindings.Add("Visible", model, "ShowEmoji");
            tIntereset.DataBindings.Add("Visible", model, "ShowEmoji");
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            // Dobra praktyka: Logika przeniesieniona do osobnej klasy (b�dzie mo�na j� w przysz�o�ci testowa�)
            model.CalculateInterest();

            // UI (odczyt)
            //  decimal leftToPaid = decimal.Parse(tLeftToPaid.Text);
            //decimal leftToPaid = nLeftToPaid.Value;
            //decimal rate = decimal.Parse(tRate.Text);

            // R�czne przypisanie 
            //model.LeftToPaid = nLeftToPaid.Value;
            //model.Rate = decimal.Parse(tRate.Text);

            // Z�a praktyka: Logika bezpo�rednio w obs�udze przycisku
            /*
            rate = rate / 100;

            int daysInYear = DateTime.IsLeapYear(DateTime.Today.Year) ? 366 : 365;
            int daysInMonth = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);

            decimal interest = leftToPaid * rate * daysInMonth / daysInYear;
            */



            // UI (zapis)
            // tIntereset.Text = model.Interest.ToString("C2");

        }

        private void tLeftToPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void miCalculate_Click(object sender, EventArgs e)
        {
            // UI (odczyt) kontrolka -> obiekt
            //model.LeftToPaid = nLeftToPaid.Value;
            //model.Rate = decimal.Parse(tRate.Text);

            // Uruchomienie logiki
            model.CalculateInterest();

            // UI (zapis) obiekt -> kontrolka
            // tIntereset.Text = model.Interest.ToString("C2");
        }
    }
}
