using App.Resx;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App.ViewModels
{
    class GraficaViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public GraficaViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }
        private async void OnLoginClicked(object obj)
        {
            await Application.Current.MainPage.DisplayAlert(
                    "GraficaViewModel",
                    "Grafica",
                    AppResources.OkText);
        }
    }
}
