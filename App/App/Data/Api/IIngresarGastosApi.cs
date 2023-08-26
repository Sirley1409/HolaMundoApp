using App.Data.Dto;
using App.Data.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Api
{
    public interface IIngresarGastosApi
    {
        [Post("/GastosViajes")]

        Task<GastosViajePost> PostGastosViajeAsync(GastoDto gastoDto);
    }
}
