using Microsoft.EntityFrameworkCore;

namespace AgenciaDeViagens.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) { }
        public DbSet<Cliente> Cliente { get; set;}
        
        public DbSet<Destino> Destino { get; set; }
      
        public DbSet<Viagem> Viagem { get; set;}

    }
}
