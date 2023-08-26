using App.Data.Api;
using App.Data.Dto;
using App.Data.Models;
using App.Resx;
using App.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class GastosViajeViewModel : BaseViewModel
    {
        private DateTime _fecha;
        private int _valor;
        private string _detallegasto;
        private ClasificacionGastos _clasificaciongastos;
        private GastoDto _gastoDto;
        private string _clasificaciongastosId;
        private GastosViaje _gastosviaje;
        private readonly IIngresarGastosServices _IngresarGastosService;
        public ICommand GuardarCommand { get; set; }
        public ICommand AppearingCommand { get; set; }
        public string ClasificacionGastosId { get => _clasificaciongastosId; set => SetProperty(ref _clasificaciongastosId, value); }
        public DateTime Fecha { get => _fecha; set => SetProperty(ref _fecha, value); }      
        public int Valor { get => _valor; set => SetProperty(ref _valor, value); }
        public string DetalleGasto { get => _detallegasto; set => SetProperty(ref _detallegasto, value); }
        public GastoDto GastoDto { get => _gastoDto; set => SetProperty(ref _gastoDto, value); }
        public GastosViaje GastosViaje { get => _gastosviaje; set => SetProperty(ref _gastosviaje, value); }
        public ObservableRangeCollection<GastosViaje> Gastos { get; set; } = new ObservableRangeCollection<GastosViaje>();

        public GastosViajeViewModel(IIngresarGastosServices ingresarGastosServices)
        {
            Title = "Gastos de Viaje";
            GuardarCommand = new AsyncCommand(async () => GuardarGastos());
            AppearingCommand = new AsyncCommand(async () => await OnAppearingAsync());
            _IngresarGastosService = ingresarGastosServices;


        }
        //public async Task PostGastosViaje(GastosViaje gastosViaje)
        //{
        //    GastoDto gastoDto = new GastoDto()
        //    {
        //        ClasificacionGastosId = gastosViaje.ClasificacionGastosId,
        //        DetalleGasto = gastosViaje.DetalleGasto,
        //        Fecha = gastosViaje.Fecha,
        //        UserId = gastosViaje.UserId,
        //        Valor = gastosViaje.Valor

        //    };
        //    await _IngresarGastosService.PostGastosViajeAsync(gastoDto);
        //}
        private async Task OnAppearingAsync()
        {
            //await LoadData();
        }

        //private async Task LoadData()
        //{
        //    try
        //    {
        //        IsBusy = true;
        //        var gastos = await _IngresarGastosService.PostGastosViajeAsync(GastoDto gastoDto);
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

        private void GuardarGastos()
        {
            long IdGastos = 0;
            if (ClasificacionGastosId == "Tiquetes o Pasajes")
            {
                IdGastos = 1;
            }
            if (ClasificacionGastosId == "Hospedaje") 
            {
                IdGastos = 2;
            }
            if (ClasificacionGastosId == "Alimentación")
            {
                IdGastos = 3;
            }
            //long GuardarUserId = Preferences.Get("UserId", defaultValue: -1);
            GastoDto gastoDto = new GastoDto()
            {
                UserId = 1,
                ClasificacionGastosId = IdGastos,
                Fecha = Fecha,
                Valor = Valor, //int.Parse(Valor.Replace('$','\0').Replace('.', '\0')),
                DetalleGasto = DetalleGasto
            };

             _IngresarGastosService.PostGastosViajeAsync(gastoDto);
            //GastoDto gastoDto = new GastoDto()
            //{
            //    ClasificacionGastosId = gastosViaje.ClasificacionGastosId,
            //    DetalleGasto = gastosViaje.DetalleGasto,
            //    Fecha = gastosViaje.Fecha,
            //    UserId = gastosViaje.UserId,
            //    Valor = gastosViaje.Valor

            //};
            //await _IngresarGastosService.PostGastosViajeAsync(gastoDto);
            //PostGastosViajeAsync(gastoDto);
        }
    }
}
