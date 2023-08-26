using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Dto
{
    public class GastoDto
    {
        public long UserId { get; set; }
        public long ClasificacionGastosId { get; set; }
        public DateTime Fecha { get; set; }
        public int Valor { get; set; }
        public string DetalleGasto { get; set; }
    }
}
