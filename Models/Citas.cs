using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopBD.Models
{
    public class Citas
    {
        [Key]
        public int IdCita { get; set; }

        [ForeignKey("Vehiculos")]
        public int IdVehiculo { get; set; }
        public Vehiculos Vehiculo { get; set; }

        [ForeignKey("Clientes")]
        public int IdCliente { get; set; }
        public Clientes Cliente { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; }

        public string DescripcionServicio { get; set; }
    }
}
