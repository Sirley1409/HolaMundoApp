using App.Models;
using App.Resx;
using App.Services;
using Microcharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using SkiaSharp;

namespace App.ViewModels
{
    class GraficaViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private Chart _barChart;
        public Command LoginCommand { get; }
        public Command GraficaCommand { get; set; }

        private readonly IVerGastosService _VerGastosService;
        public Chart BarChart
        {
            get { return _barChart; }
            set { SetProperty(ref _barChart, value); }
        }

        public GraficaViewModel(IVerGastosService VerGastosService)
        {
            Title = "Gráfica";
            LoginCommand = new Command(OnLoginClicked);
            _VerGastosService = VerGastosService;
            GraficaCommand = new Command(GenerarGrafica);
        }

        private async void GenerarGrafica()
        {
            try
            {
                IsBusy = true;
                var Listagastos = await _VerGastosService.GetGastosViajeAsync();
                List<DatosGrafica> ListadoGrafica = new List<DatosGrafica>();
                if (Listagastos != null)
                {
                    ListadoGrafica = Listagastos
                                    .GroupBy(a => a.ClasificacionGastosId)
                                        .Select(DR => new DatosGrafica
                                        {
                                            ClasificacionGastosId = DR.First().ClasificacionGastosId,
                                            Valor = (int)(float)DR.Sum(c => c.Valor),
                                        }).ToList();

                }
            }
            catch (Exception ex) 
            { 
                var message = ex.Message;
            }
            throw new NotImplementedException();
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
