using System.ComponentModel.DataAnnotations;

namespace Clientesej1.Models
{
    public class Vehiculo
    {
        [Required]
        public string Placa { get; set; } = string.Empty;

        [Required]
        public string Marca { get; set; } = string.Empty;

        [Required]
        public string Modelo { get; set; } = string.Empty;
    }
}