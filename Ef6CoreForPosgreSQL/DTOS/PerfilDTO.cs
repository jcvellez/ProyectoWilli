using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ef6CoreForPosgreSQL.DTOS
{
    public class PerfilDTO
    {
        public int id { get; set; }
        [Required(ErrorMessage = "La Farmacia es requerida")]
        public int IdFarmacia { get; set; }
        [Required(ErrorMessage = "El Usuario es requerido")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "El Nombre es requerido")]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El correo de la Cuenta es requerido")]
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "La cedula de identidad es requerida")]
        public string Cedula { get; set; }
        public int Rol { get; set; }
        public int Edad { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }

    }
}
