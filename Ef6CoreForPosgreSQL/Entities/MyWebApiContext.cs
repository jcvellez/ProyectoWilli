using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ef6CoreForPosgreSQL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace Ef6CoreForPosgreSQL.Models
{
    public class MyWebApiContext:DbContext
    {
        public MyWebApiContext(DbContextOptions<MyWebApiContext> options):base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }

        public DbSet<IUsuario> Usuarios { get; set; }
        public DbSet<IPerfil> Perfil { get; set; }
        public DbSet<IFarmacia> Farmacias { get; set; }
        public DbSet<IUserScanner> UserScanners { get; set; }
        public DbSet<IFiles> Files { get; set; }
        public DbSet<INotificacion> Notificacion { get; set; }
    }
}
