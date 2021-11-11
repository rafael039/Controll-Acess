using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Control_Acess.Models
{
    public class UsuarioContext : DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }

        public UsuarioContext(DbContextOptions<UsuarioContext> options) :
            base(options)
        {
        }
    }
}
