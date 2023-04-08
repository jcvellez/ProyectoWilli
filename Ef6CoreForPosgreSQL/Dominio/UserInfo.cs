using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ef6CoreForPosgreSQL.Dominio
{
    public class UserInfo
    {
        public string Nombre { get; set; }
        public string Mail { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
