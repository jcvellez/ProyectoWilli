using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ef6CoreForPosgreSQL.Entities
{
    public class INotificacion
    {
        public int id { get; set; }
        public string Uid { get; set; }
        public string NotId { get; set; }
    }
}
