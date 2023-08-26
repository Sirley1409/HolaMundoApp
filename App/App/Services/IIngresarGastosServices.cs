using App.Data.Dto;
using App.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public interface IIngresarGastosServices
    {
      void PostGastosViajeAsync(GastoDto gastoDto);
    }
}
