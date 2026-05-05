using System.ComponentModel.DataAnnotations;

namespace Clientesej1.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "EL Nit es requerido")]
        [StringLength(13, ErrorMessage = "El nit tiene que tener 13 caracteres")]
        public string Nit { get; set; } = string.Empty;


        [Required(ErrorMessage = "EL Nombre es requerido")]
        [Display (Name =  " Nombre del cliente")]
        public string Nombre { get; set; } = string.Empty;


        [Required(ErrorMessage = "EL Apellido es requerido")]
        [Display(Name = " Apellido del cliente")]
        public string Apellido { get; set; } = string.Empty;
        public int Edad {  get; set; }
    }
}
