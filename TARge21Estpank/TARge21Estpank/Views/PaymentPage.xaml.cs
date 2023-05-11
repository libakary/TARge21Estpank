namespace TARge21Estpank.Views;

public partial class PaymentPage : ContentPage
{
    public double AccountBalance { get; set; }
    public string AccountBalanceDisplayed { get; set; }
    public PaymentPage()
	{
		InitializeComponent();
	}

    private async void OnBackClicked1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void Makstud_Clicked(object sender, EventArgs i)
    {
        if (!string.IsNullOrEmpty(MakseSuurus.Text) && !string.IsNullOrEmpty(TeineKontoNr.Text))
        {
            await Navigation.PushAsync(new PaymentPage());
            await DisplayAlert("Õnnestus", "Makse on tehtud!", "Edasi");
        }
        else
        {
            await DisplayAlert("Viga", "Proovi uuesti, äkki veab.", "Tagasi");
        }
    }
}