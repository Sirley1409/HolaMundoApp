using App.Data.Api;
using App.Data.Models;
using App.Resx;
using App.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
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
        private DateTime _fecha;
        public DateTime Fecha { get => _fecha; set => SetProperty(ref _fecha,value); }
        private async void OnLoginClicked(object obj)
        {
            await Application.Current.MainPage.DisplayAlert(
                    "GastosViajeViewModel",
                    "Gastos de Viaje",
                    AppResources.OkText);
        }
        
    }
}
