using Firebase.Auth;
using gorselodev.Model;
using Microsoft.Maui.ApplicationModel.Communication;

namespace gorselodev;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    private void KayitLoginEkraniGoster(object sender, EventArgs e)
    {
        if (kayitEkran.IsVisible)
        {
            kayitEkran.IsVisible = false;
            loginEkran.IsVisible = true;
        }
        else
        {
            loginEkran.IsVisible = false;
            kayitEkran.IsVisible = true;
        }
    }

    private async void LoginClicked(object sender, EventArgs e)
    {
        var user = await FireBaseServices.Login(txtEmail.Text, txtPassword.Text);
        if (user != null)
        {
            if (Application.Current.MainPage is AppShell shell)
            {
                shell.SetFlyoutBehavior(FlyoutBehavior.Flyout);
                shell.OpenFlyout();
            }

            await DisplayAlert("Başarılı", $"Uygulamaya Hoş Geldin {user.Info.DisplayName}", "OK");

            await Shell.Current.GoToAsync("//Giris");


        }
        else
        {
            await DisplayAlert("Hata", "Kullanıcı Adı Veya Şifre Yanlış", "OK");
        }

    }

    private async void RegisterClicked(object sender, EventArgs e)
    {
        var user = await FireBaseServices.Register(txtName.Text, txtREmail.Text, txtRPassword.Text);
        if (user != null)
        {

            if (Application.Current.MainPage is AppShell shell)
            {
                shell.SetFlyoutBehavior(FlyoutBehavior.Flyout);
                shell.OpenFlyout();
            }

            await DisplayAlert("Başarılı", $"Uygulamaya Hoş Geldin {user.Info.DisplayName}", "OK");

            await Shell.Current.GoToAsync("//Giris");

        }
        else
        {
            await DisplayAlert("Hata", "Kayıt Başarısız", "OK");
        }
    }
}


