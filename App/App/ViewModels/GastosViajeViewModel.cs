using App.Resx;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class GastosViajeViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public GastosViajeViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }
        private async void OnLoginClicked(object obj)
        {
            await Application.Current.MainPage.DisplayAlert(
                    "GastosViajeViewModel",
                    "Gastos de Viaje",
                    AppResources.OkText);
        }
    }
}
