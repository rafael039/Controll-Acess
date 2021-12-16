using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control_Acess.Models;
using Microsoft.EntityFrameworkCore;
using Control_Acess.Seeds;

namespace Control_Acess.Context

{
    public class UsuarioContext : DbContext
    {
        public DbSet<UserRolesViewModel> Usuarios { get; set; }

        public UsuarioContext(DbContextOptions<UsuarioContext> options) :
            base(options)
        {
        }
    }
}
