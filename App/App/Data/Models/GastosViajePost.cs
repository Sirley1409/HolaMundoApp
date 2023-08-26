using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Models
{
    public class GastosViajePost
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int clasificacionGastosId { get; set; }
        public DateTime fecha { get; set; }
        public int valor { get; set; }
        public string detalleGasto { get; set; }
        public User user { get; set; }
        public ClasificacionGastos clasificacionGastos { get; set; }
    }
}
