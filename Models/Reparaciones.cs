using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopBD.Models
{
    public class Reparaciones
    {
        [Key]
        public int IdReparacion { get; set; }

        public string Descripcion { get; set; }

        [ForeignKey("Vehiculos")]
        public int IdVehiculo { get; set; }
        public Vehiculos Vehiculo { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal CostoEstimado { get; set; }
    }
}
