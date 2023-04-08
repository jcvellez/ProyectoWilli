using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ef6CoreForPosgreSQL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ef6CoreForPosgreSQL.Controllers
{
    [Produces("application/json")]
    [Route("api/Farmacias")]
    public class UsersController : Controller
    {
        private MyWebApiContext _context;

        public UsersController(MyWebApiContext context)
        {
            _context = context;
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult GetUsers()
        {
            var usersToReturn = _context.Farmacias.ToList();
            return Ok(usersToReturn);
        }
    }
}