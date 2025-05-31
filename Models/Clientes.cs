using System.ComponentModel.DataAnnotations;

namespace AutoShopBD.Models
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        [EmailAddress]
        public string Correo { get; set; }

        public string Direccion { get; set; }

        public ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
