using Dqc.Infraestructure.EFCore;
using EstudioAbogados.Domain;
using EstudioAbogados.Infraestructure.EFCore.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace EstudioAbogados.Infraestructure.EFCore
{
    public class EstudioAbogadosDbContext : DbContextBase
    {
        public DbSet<Abogado> Abogado { get; set; }

        public EstudioAbogadosDbContext(DbContextOptions<EstudioAbogadosDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AbogadoEntityTypeConfiguration());
        }
    }
}
