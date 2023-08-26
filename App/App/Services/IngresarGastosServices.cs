using App.Data.Api;
using App.Data.API;
using App.Data.Dto;
using App.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App.Services
{
    public class IngresarGastosServices : IIngresarGastosServices
    {
        private readonly IIngresarGastosApi _IngresarGastosApi;
        public IngresarGastosServices(IIngresarGastosApi IngresarGastosApi)
        {
            _IngresarGastosApi = IngresarGastosApi;
        }

        public async void PostGastosViajeAsync(GastoDto gastoDto)
        {
            try
            {
                var response = await _IngresarGastosApi.PostGastosViajeAsync(gastoDto);
                if (response == null)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "No se pudo guardar los gastos", "Aceptar");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Mensaje", "Gastos guardados con éxito", "Aceptar");
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

            //if (response.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    await Application.Current.MainPage.DisplayAlert("Mensaje","Gastos guardados con exito","Aceptar");
            //}
            //else
            //{
            //    await Application.Current.MainPage.DisplayAlert("Error", "Gastos No Guardados", "Aceptar");
            //}
        }


        //Task<GastosViaje> IIngresarGastosServices.PostGastosViajeAsync(GastoDto gastoDto)
        //{
        //    throw new NotImplementedException();
        //}
        //public async Task<List<GastosViaje>> PostGastosViajeAsync()
        //{
        //    var Gastos = new List<GastosViaje>();
        //    try
        //    {
        //        var response = await _IngresarGastosServicesApi.PostGastosViajeAsync();
        //        Gastos = response.ToList();
        //        return Gastos;

        //    }
        //    catch (Exception ex)
        //    {

        //        var error = ex.Message;
        //    }
        //    return Gastos;
        //}
    }
}
