namespace RegisterLogin.Views;
using RegisterLogin.Services;

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
     private async void ButtonLogin_Clicked(object sender, EventArgs e)
    {
        string entUsername = EntryUserName.Text;
        string entPassword = EntryPassword.Text;
        string username = LocalDataService.GetInstance().GetUser().UserName;
        string password = LocalDataService.GetInstance().GetUser().Password;
        if (entUsername != "" && entPassword != "")
        {
            if (LocalDataService.GetInstance().IsUserRegistered(EntryUserName.Text, EntryPassword.Text))
            {
                LblMessage.Text = EntryUserName.Text + " welcome!";
            }
            else if (username == EntryUserName.Text)
            {
                LblMessage.Text = "Wrong password";
            }
            else if (password == EntryPassword.Text)
            {
                LblMessage.Text = "Wrong username";
            }
        }
        else
        {
            LblMessage.Text = "Fill both the username and password";
        }
    }
}