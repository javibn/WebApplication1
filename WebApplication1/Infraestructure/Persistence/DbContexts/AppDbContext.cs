using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain;

namespace WebApplication1.Infraestructure.Persistence.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        

        public DbSet<Ejercicio> Ejercicio { get; set; }
        public DbSet<Dia> Dias { get; set; }
        public DbSet<Weight> Weights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}