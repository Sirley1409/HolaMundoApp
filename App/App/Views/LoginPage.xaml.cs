using App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //this.BindingContext = new LoginViewModel();
        }
        //private void OnLoginButtonClicked(object sender, EventArgs e)
        //{
        //    string username = UsernameEntry.Text;
        //    string password = PasswordEntry.Text;

        //    // Aquí puedes agregar la lógica de verificación del usuario y contraseña.
        //    // Por ejemplo, puedes compararlos con datos almacenados en una base de datos o
        //    // realizar una llamada a una API para autenticar al usuario.

        //    // Ejemplo de validación simple (para propósitos de demostración):
        //    if (username == "sflorez" && password == "1234")
        //    {
        //        // Si el usuario y la contraseña son válidos, puedes navegar a la siguiente página.
        //        // Por ejemplo, si tienes una página llamada "MainPage.xaml", puedes hacer lo siguiente:
        //        // await Navigation.PushAsync(new MainPage());

        //        // Aquí, por fines de demostración, mostraremos un mensaje de éxito:
        //        WelcomeLabel.Text = "Inicio de sesión exitoso, " + "¡Bienvenido! " + username + "!";
        //        WelcomeLabel.IsVisible = true;
        //        WelcomeLabel.TextColor = Color.Green;
        //    }
        //    else
        //    {
        //        // Si las credenciales son incorrectas, muestra un mensaje de error.
        //        WelcomeLabel.Text = "Usuario o contraseña incorrectos";
        //        WelcomeLabel.TextColor = Color.Red;
        //        WelcomeLabel.IsVisible = true;
        //        //DisplayAlert("Error de inicio de sesión", "Usuario o contraseña incorrectos", "OK");

        //    }
        //}
    }
}