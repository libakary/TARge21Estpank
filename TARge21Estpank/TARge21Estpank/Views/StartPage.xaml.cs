namespace TARge21Estpank.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

	async void Sisene_Clicked(System.Object sender, System.EventArgs e)
		=> Application.Current.MainPage = new NavigationPage(new LoginPage());
}