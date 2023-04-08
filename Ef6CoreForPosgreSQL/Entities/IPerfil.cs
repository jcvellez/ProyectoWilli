using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ef6CoreForPosgreSQL.Entities
{
    public class IPerfil
    {
        public int id { get; set; }
        public int IdFarmacia { get; set; }
        public string Usuario { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Rol { get; set; }
        public bool Habilitado { get; set; }



    }
}
