using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaGestionEntities;

namespace SistemaGestionData.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            const string CONNECTION_STRING = 
                "Data Source=localhost\\SQLExpress;Initial Catalog=SistemaGestionDB;Integrated Security=True;Trust Server Certificate=True";

            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasKey(p => p.Id);
            modelBuilder.Entity<Producto>().HasKey(p => p.Id);
            modelBuilder.Entity<ProductoVendido>().HasKey(p => p.Id);
            modelBuilder.Entity<Venta>().HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Usuario>? Usuarios { get; set; }
        public virtual DbSet<Producto>? Productos { get; set; }
        public virtual DbSet<ProductoVendido>? ProductosVendidos { get; set; }
        public virtual DbSet<Venta>? Ventas { get; set; }
    }
}
