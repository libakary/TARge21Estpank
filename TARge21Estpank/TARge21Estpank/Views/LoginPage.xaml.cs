namespace TARge21Estpank.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Sisene_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UsernameEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text))
            {
                await Navigation.PushAsync(new BalancePage(UsernameEntry.Text));
                await DisplayAlert("Õnnestus", $"Tere, {UsernameEntry.Text}!", "Edasi");
            }
            else
            {
                await DisplayAlert("Viga", "Proovi uuesti, äkki veab.", "Tagasi");
            }
        }
    }
}