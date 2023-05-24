namespace TARge21Estpank.Views
{
    public partial class LoginPage : ContentPage
    {
		public LoginPage()
        {
            InitializeComponent();

            //adminUsername = "admin";
            //adminPassword = 1234;
        }

        private async void Sisene_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UsernameEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text))
            {
                string username = UsernameEntry.Text;
                string password = PasswordEntry.Text;

                if (username == "admin" && password == "1234")
                {
                    await Navigation.PushAsync(new BalancePage(username));
                    await DisplayAlert("Õnnestus", $"Tere, {username}!", "Edasi");
                }
                else
                {
                    await DisplayAlert("Viga", "Vale kasutajanimi või parool.", "Tagasi");
                }
            }
            else
            {
                await DisplayAlert("Viga", "Proovi uuesti, äkki veab.", "Tagasi");
            }
        }
    }
}