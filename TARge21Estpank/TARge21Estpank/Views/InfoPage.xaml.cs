namespace TARge21Estpank.Views;

public partial class InfoPage : ContentPage
{
	public InfoPage(string username, string balance)
	{
		InitializeComponent();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    //see kontaktid nupp
    private async void OnCallClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Helistamine...", "Teises aknas avaneb kõnerakendus.", "Tagasi");
    }
}