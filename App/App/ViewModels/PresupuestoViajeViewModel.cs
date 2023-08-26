using App.Data.API;
using App.Data.Models;
using App.Resx;
using App.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace App.ViewModels
{
   public class PresupuestoViajeViewModel : BaseViewModel
    {
        #region Properties
        public ObservableRangeCollection<GastosViaje> Gastos { get; set; } = new ObservableRangeCollection<GastosViaje>();
        public ICommand AppearingCommand { get; set; }
        public Command LoginCommand { get; }
        public ICommand GastosTappedCommand { get; set; }
        #endregion
        private readonly IVerGastosService _VerGastosService;
        public PresupuestoViajeViewModel(IVerGastosService VerGastosService)
        {
            Title = "Presupuesto";
            AppearingCommand = new AsyncCommand(async () => await OnAppearingAsync());
            GastosTappedCommand = new AsyncCommand<GastosViaje>(OnGastosTapped);
            _VerGastosService = VerGastosService;
        }

       
        private async Task OnAppearingAsync()
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                IsBusy = true;
                var gastos = await _VerGastosService.GetGastosViajeAsync();
                if (gastos != null)
                {
                    Gastos.ReplaceRange(gastos);
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }
            finally
            {
                IsBusy = false;
            }
        }
        private Task OnGastosTapped(GastosViaje gastos)
        {
            throw new NotImplementedException();
        }
    }
}
