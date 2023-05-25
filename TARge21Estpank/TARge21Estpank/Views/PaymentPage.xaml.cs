using System.ComponentModel;

namespace TARge21Estpank.Views
{
    public partial class PaymentPage : ContentPage, INotifyPropertyChanged
    {
        private double _accountBalance;
        public double AccountBalance
        {
            get { return _accountBalance; }
            set
            {
                if (_accountBalance != value)
                {
                    _accountBalance = value;
                    OnPropertyChanged(nameof(AccountBalance));
                    OnPropertyChanged(nameof(AccountBalanceDisplayed));
                }
            }
        }

        public string AccountBalanceDisplayed => AccountBalance.ToString("F");

        public event Action<double> PaymentMade;

        public PaymentPage(double accountBalance)
        {
            InitializeComponent();
            AccountBalance = accountBalance;
            BindingContext = this;
        }

        private async void OnBackClicked1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Makstud_Clicked(object sender, EventArgs i)
        {
            if (!string.IsNullOrEmpty(MakseSuurus.Text) && !string.IsNullOrEmpty(TeineKontoNr.Text))
            {
                double paymentAmount = double.Parse(MakseSuurus.Text);

                if (AccountBalance >= paymentAmount)
                {
                    AccountBalance -= paymentAmount;
                    PaymentMade?.Invoke(AccountBalance);

                    MakseSuurus.Text = "";
                    TeineKontoNr.Text = "";

                    await DisplayAlert("Õnnestus", "Makse on tehtud!", "Edasi");
                }
                else
                {
                    await DisplayAlert("Viga", "Kontol pole piisavalt vahendeid.", "Tagasi");
                }
            }
            else
            {
                await DisplayAlert("Viga", "Proovi uuesti, äkki veab.", "Tagasi");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}