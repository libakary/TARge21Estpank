namespace TARge21Estpank.Views;

public partial class BalancePage : ContentPage
{
	public BalancePage()
	{
		InitializeComponent();
	}
    async void Maksed_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new StartPage()); //MaksedPage
    async void Kontakt_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new StartPage()); //KontaktPage
}