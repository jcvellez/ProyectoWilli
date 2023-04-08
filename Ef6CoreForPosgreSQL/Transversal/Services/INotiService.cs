using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Ef6CoreForPosgreSQL.Transversal.Services
{
    public interface INotiService
    {


        Task SendNotification(string NotId, string title, string message);

    }
}
