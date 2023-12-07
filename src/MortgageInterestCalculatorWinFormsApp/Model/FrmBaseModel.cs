using System.ComponentModel;

namespace MortgageInterestCalculatorWinFormsApp.Model
{
    // INotifyPropertyChanged - interfejs, który odpowiedzialny jest za powiadamanie kontrolek, że zmieniła się jakaś właściwość na obiekcie

    internal abstract class FrmBaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        // Metoda pomocnicza do wysyłania zdarzenia PropertyChanged
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
