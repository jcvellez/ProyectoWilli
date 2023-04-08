using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ef6CoreForPosgreSQL.DTOS
{
    public class UserScannerDTO
    {
        public int IdUserScanner { get; set; }
        [Required(ErrorMessage = "El Usuario Admin es requerido")]
        public int IdPerfil { get; set; }
        [Required(ErrorMessage = "El establecimiento es requerido")]
        public int IdFarmacia { get; set; }
        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        public string User { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
        public string Correo { get; set; }


    }
}
