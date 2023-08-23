using App.Data.Api;
using App.Data.API;
using App.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class VerGastosService : IVerGastosService
    {
        private readonly IGastosViajeApi _GastosViajeApi;
        public VerGastosService(IGastosViajeApi GastosViajeApi)
        {
            _GastosViajeApi = GastosViajeApi;
        }

        public async Task<List<GastosViaje>> GetGastosViajeAsync()
        {
            var Gastos = new List<GastosViaje>();
            try
            {
                var response = await _GastosViajeApi.GetGastosViajeAsync();
                Gastos = response.ToList();
                return Gastos;

            }
            catch (Exception ex)
            {

                var error = ex.Message;
            }
            return Gastos;
        }

    }
}

