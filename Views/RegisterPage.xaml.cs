namespace RegisterLogin.Views;
using System.Text.RegularExpressions;
public partial class RegisterPage : ContentPage
{
    bool isValid;
    public RegisterPage()
    {
        InitializeComponent();
        EntryUserName.Text = "";
        EntryUserEmail.Text = "";
        EntryPassword.Text = "";
    }

    private void ResetErrors()
    {
        LblErrorName.Text = "";
        LblErrorPassword.Text = "";
    }
    private void ButtonRegister_Clicked(object sender, EventArgs e)
    {
        ResetErrors();
        isValid = true;

        if (EntryUserName.Text.Length < 5)
        {
            LblErrorName.Text = "Too short must be above 5 chars";
            isValid = false;
        }

        string passPattern = @"^(?=.*[A-Z])(?=.*[!@#$%^&*(),.?"":{}|<>])[A-Za-z\d!@#$%^&*(),.?"":{}|<>]{8,}$";
        bool isPasswordOk = Regex.IsMatch(EntryPassword.Text, passPattern);

        string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
        bool isEmailOk = Regex.IsMatch(EntryUserEmail.Text, emailPattern);

        if (!isPasswordOk)
        {
            LblErrorPassword.Text = "Password must be at least 8 chars, contain an uppercase letter and a special char";
            isValid = false;
        }

        if (!isEmailOk)
        {
            LblErrorUserEmail.Text = "Valid email address";
            isValid = false;
        }

        if ( isValid )
        {
            LblMessage.Text = "Registration's done successfully!";
        }
    }
    private void Button_TogglePassword_Clicked(object sender, EventArgs e)
    {
        EntryPassword.IsPassword = !EntryPassword.IsPassword;
    }

}