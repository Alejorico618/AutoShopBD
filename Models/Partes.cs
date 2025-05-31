using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopBD.Models
{
    public class Partes
    {
        [Key]
        public int IdParte { get; set; }

        public string Nombre { get; set; }

        public string NumeroParte { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public string Proveedor { get; set; }
    }
}
