using App.Data.Dto;
using App.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Models
{
    public class DatosGrafica
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long ClasificacionGastosId { get; set; }
        public int Valor { get; set; }


    }
}
