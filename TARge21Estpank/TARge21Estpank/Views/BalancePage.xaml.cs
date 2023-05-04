namespace TARge21Estpank.Views;

public partial class BalancePage : ContentPage
{
    public decimal AccountBalance { get; set; }

    public BalancePage(string username)
    {
        InitializeComponent();

        UsernameLabel.Text = $"Hello, {username}!";
        Random random = new Random();
        AccountBalance = (decimal)random.NextDouble() * 10000;

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