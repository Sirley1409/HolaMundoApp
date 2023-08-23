using App.Data.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Models
{
    public class GastosViaje
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long ClasificacionGastosId { get; set; }
        public DateTime Fecha { get; set; }
        public int Valor { get; set; }
        public string DetalleGasto { get; set; } = string.Empty;
        public UserDto User { get; set; } 
        public ClasificacionGastos ClasificacionGastos { get; set; }
    }
}
