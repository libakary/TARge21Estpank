using System.ComponentModel;

namespace TARge21Estpank.Views
{
    public partial class BalancePage : ContentPage, INotifyPropertyChanged
    {
        private double accountBalance;
        private string accountBalanceDisplayed;

        public double AccountBalance
        {
            get { return accountBalance; }
            set
            {
                if (accountBalance != value)
                {
                    accountBalance = value;
                    OnPropertyChanged(nameof(AccountBalance));
                    AccountBalanceDisplayed = AccountBalance.ToString("F");
                }
            }
        }

        public string AccountBalanceDisplayed
        {
            get { return accountBalanceDisplayed; }
            set
            {
                if (accountBalanceDisplayed != value)
                {
                    accountBalanceDisplayed = value;
                    OnPropertyChanged(nameof(AccountBalanceDisplayed));
                }
            }
        }

        public BalancePage(string username)
        {
            InitializeComponent();

            UsernameLabel.Text = $"Tere, {username}!";
            Random random = new Random();
            AccountBalance = (double)random.NextDouble() * 10000;
            AccountBalanceDisplayed = AccountBalance.ToString("F");

            BindingContext = this;
        }

        private async void OnLogOutClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        //see kontaktid nupp
        private async void OnInfoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage(UsernameLabel.Text, BalanceLabel.Text));
        }

        //see maksed nupp
        private async void OnDetailsClicked(object sender, EventArgs e)
        {
            var paymentPage = new PaymentPage(AccountBalance);
            paymentPage.PaymentMade += OnPaymentMade;
            await Navigation.PushAsync(paymentPage);
        }

        private void OnPaymentMade(double newBalance)
        {
            AccountBalance = newBalance;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}