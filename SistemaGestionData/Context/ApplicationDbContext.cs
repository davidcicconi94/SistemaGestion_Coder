using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData.Context
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>().HasKey(p => p.Id);



            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}
