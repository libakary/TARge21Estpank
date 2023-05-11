namespace TARge21Estpank.Views
{
    public partial class LoginPage : ContentPage
    {
		//public string adminUsername { get; set; }
		//public int adminPassword { get; set; }
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
                await Navigation.PushAsync(new BalancePage(UsernameEntry.Text));
                await DisplayAlert("Õnnestus", $"Tere, {UsernameEntry.Text}!", "Edasi");
            }
            //else ((UsernameEntry.ToString != adminUsername.ToString) && (PasswordEntry.ToString != adminPassword.ToString))
            //{

            //}
            else
            {
                await DisplayAlert("Viga", "Proovi uuesti, äkki veab.", "Tagasi");
            }
        }
    }
}