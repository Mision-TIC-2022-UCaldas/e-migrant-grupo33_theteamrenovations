using Microsoft.EntityFrameworkCore;
using Emigrant.App.Dominio;

namespace Emigrant.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Migrante> Migrantes { get; set; }
        public DbSet<servicios> Servicios { get; set; }
        public DbSet<Necesidad> Necesidades { get; set; }
        public DbSet<grupoMigrante> Grupos { get; set; }
        public DbSet<Novedad> Novedades { get; set; }
        public DbSet<Entidad> Entidades { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog= Emigrant_grupo33");

            }
        }
    }
}