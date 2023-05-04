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

    private async void OnInfoClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Rohkem infot", "Veel infot", "Tagasi");
    }

    private async void OnDetailsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Kasutaja info", "Mingi info", "Tagasi");
    }
}