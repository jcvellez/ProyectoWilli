using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ef6CoreForPosgreSQL.Entities
{
    public class IUsuario
    {
        [Required]
        public int id { get; set; }
        [Required]
        [EmailAddress]
        public string Mail { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required]
        public string UserName { get; set; }

        public string Dni { get; set; }

        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public int Rol { get; set; }

    }
}
