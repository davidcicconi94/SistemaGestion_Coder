using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;

namespace SistemaGestionData.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}
