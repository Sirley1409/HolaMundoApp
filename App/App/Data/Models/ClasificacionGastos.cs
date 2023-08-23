using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using App.Enumerations;

namespace App.Data.Models
{
    public class ClasificacionGastos
    {
        public long GastosId { get; set; }

        public GastosTipo NombreGasto { get; set; } 

        public string Name { get; set; } = string.Empty;
    }
}