using App.Data.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.API

{
   public interface IGastosViajeApi
    {
        [Get("/GastosViajes")]

        Task<List<GastosViaje>> GetGastosViajeAsync();
    }
}
