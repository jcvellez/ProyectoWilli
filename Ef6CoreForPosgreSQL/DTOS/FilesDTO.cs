using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ef6CoreForPosgreSQL.DTOS
{
    public class FilesDTO
    {
        public int IdUserScanner { get; set; }
        public int IdPerfil { get; set; }
        public int IdFarmacia { get; set; }
        public string User { get; set; }
        [Required(ErrorMessage = "El Typo de archivo es requerido")]
        public string Type { get; set; }
        [Required(ErrorMessage = "La data es requerida")]
        public string Data { get; set; }
        [Required(ErrorMessage = "El nombre  del archivo es requerido")]
        public string Nombre { get; set; }
        public DateTime Creado { get; set; }

    }
}
