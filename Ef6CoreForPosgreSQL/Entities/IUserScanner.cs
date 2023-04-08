using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ef6CoreForPosgreSQL.Entities
{
    public class IUserScanner
    {
        [Key]
        public int IdUserScanner { get; set; }
        public int IdPerfil { get; set; }
        public int IdFarmacia { get; set; }
        public string User { get; set; }
        public string Correo { get; set; }


    }
}
