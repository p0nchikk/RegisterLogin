namespace RegisterLogin.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private void ButtonReset_Clicked(object sender, EventArgs e)
    {
        EntryUserName.Text = "";
        EntryPassword.Text = "";
    }
    private void Button_TogglePassword_Clicked(object sender, EventArgs e)
    {
        EntryPassword.IsPassword = !EntryPassword.IsPassword;
    }
    private async void ButtonGoToRegister_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
}