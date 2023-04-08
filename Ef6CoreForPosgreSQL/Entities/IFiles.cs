using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ef6CoreForPosgreSQL.Entities
{
    public class IFiles
    {
        [Key]
        public int IdFile { get; set; }
        public int IdUserScanner { get; set; }
        public int IdPerfil { get; set; }
        public int IdFarmacia { get; set; }
        public string URL { get; set; }
        public string User { get; set; }
        public string Nombre { get; set; }
        public string Type { get; set; }
        public string Estado { get; set; }
        public DateTime FechaSubida { get; set; }
    }
}
