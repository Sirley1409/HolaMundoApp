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
        private async void OnLoginClicked(object obj)
        {
            await Application.Current.MainPage.DisplayAlert(
                    "GastosViajeViewModel",
                    "Gastos de Viaje",
                    AppResources.OkText);
        }
        //private readonly IVerGastosService _VerGastosService;

        //public GastosViajeViewModel(IVerGastosService VerGastosService)
        //{
        //    AppearingCommand = new AsyncCommand(async()=> await OnAppearingAsync());
        //    GastosTappedCommand = new AsyncCommand<GastosViaje>(OnGastosTapped);
        //    Title = "Gastos";
        //    _VerGastosService = VerGastosService;
        //}

        //#region Properties
        //public ObservableRangeCollection<GastosViaje> Gastos { get; set; } = new ObservableRangeCollection<GastosViaje>();

        //public ICommand AppearingCommand { get; set; }
        //public ICommand GastosTappedCommand { get; set; }
        //#endregion
        //private async Task OnAppearingAsync()
        //{
        //    await LoadData();
        //}

        //private async Task LoadData()
        //{
        //    try
        //    {
        //        IsBusy = true;
        //        var gastos = await _VerGastosService.GetGastosViajeAsync();
        //        if (gastos != null)
        //        {
        //            Gastos.ReplaceRange(gastos);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        var message = ex.Message;
        //    }
        //    finally
        //    {
        //        IsBusy = false;
        //    }
        //}
        //private Task OnGastosTapped(GastosViaje gastos)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
