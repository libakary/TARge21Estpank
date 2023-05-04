namespace TARge21Estpank.Views;

public partial class BalancePage : ContentPage
{
    public double AccountBalance { get; set; }
    public string AccountBalanceDisplayed { get; set; }


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

    private async void OnInfoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InfoPage(UsernameLabel.Text, BalanceLabel.Text));
    }

    private async void OnDetailsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Detailid", "Siin on paar detaili", "OK");
    }
}