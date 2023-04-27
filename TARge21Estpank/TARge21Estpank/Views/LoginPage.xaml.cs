namespace TARge21Estpank.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	async void Login_Clicked(System.Object sender, System.EventArgs e)
	{
		await Navigation.PushAsync(new BalancePage());
	}

}