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

        #region DbSets
        public virtual DbSet<Usuario>? Usuarios { get; set; }
        public virtual DbSet<Producto>? Productos { get; set; }
        public virtual DbSet<ProductoVendido>? ProductosVendidos { get; set; }
        public virtual DbSet<Venta>? Ventas { get; set; }
        #endregion

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

            SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private static ModelBuilder SeedData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Nombre = "Jae",
                    Apellido = "Brignall",
                    Mail = "jbrignall0@timesonline.co.uk",
                    Contrasenia = "sC6%bv.1cQ1.p4IX",
                    NombreUsuario = "jbrignall0"
                },
                new Usuario
                {
                    Id = 2,
                    Nombre = "Darci",
                    Apellido = "Santora",
                    Mail = "dsantora1@blogspot.com",
                    Contrasenia = "wG9@\\XLplgECZN{",
                    NombreUsuario = "dsantora1"
                },
                new Usuario
                {
                    Id = 3,
                    Nombre = "Linea",
                    Apellido = "Godsmark",
                    Mail = "lgodsmark2@taobao.com",
                    Contrasenia = "rO5}&C$$<e\"$",
                    NombreUsuario = "lgodsmark2"
                },
                new Usuario
                {
                    Id = 4,
                    Nombre = "Faun",
                    Apellido = "Gaine",
                    Mail = "fgaine3@baidu.com",
                    Contrasenia = "eJ8($/R5*@",
                    NombreUsuario = "fgaine3"
                },
                new Usuario
                {
                    Id = 5,
                    Nombre = "Matt",
                    Apellido = "Indgs",
                    Mail = "mindgs4@senate.gov",
                    Contrasenia = "dF5!$f*)P",
                    NombreUsuario = "mindgs4"
                },
                new Usuario
                {
                    Id = 6,
                    Nombre = "Hertha",
                    Apellido = "Dyers",
                    Mail = "hdyers5@nature.com",
                    Contrasenia = "fR9@9v%S?D03N(9b",
                    NombreUsuario = "hdyers5"
                },
                new Usuario
                {
                    Id = 7,
                    Nombre = "Myrta",
                    Apellido = "Cadigan",
                    Mail = "mcadigan6@123-reg.co.uk",
                    Contrasenia = "uU1#&P3J",
                    NombreUsuario = "mcadigan6"
                },
                new Usuario
                {
                    Id = 8,
                    Nombre = "Carling",
                    Apellido = "Cran",
                    Mail = "ccran7@ow.ly",
                    Contrasenia = "cE6#lOe63p",
                    NombreUsuario = "ccran7"
                },
                new Usuario
                {
                    Id = 9,
                    Nombre = "Felicity",
                    Apellido = "Gilroy",
                    Mail = "fgilroy8@liveinternet.ru",
                    Contrasenia = "lW6\\w%5818g",
                    NombreUsuario = "fgilroy8"
                },
                new Usuario
                {
                    Id = 10,
                    Nombre = "Marnie",
                    Apellido = "Grosvenor",
                    Mail = "mgrosvenor9@nature.com",
                    Contrasenia = "lU9''v`cO",
                    NombreUsuario = "mgrosvenor9"
                }
            );


            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = 1,
                    Descripcion = "Microondas",
                    Costo = 175.98M,
                    PrecioVenta = 543.11M,
                    Stock = 333,
                    IdUsuario = 10,
                },
                new Producto
                {
                    Id = 2,
                    Descripcion = "Heladera",
                    Costo = 281.75M,
                    PrecioVenta = 830.27M,
                    Stock = 108,
                    IdUsuario = 4,
                },
                new Producto
                {
                    Id = 3,
                    Descripcion = "Cama",
                    Costo = 236.55M,
                    PrecioVenta = 848.15M,
                    Stock = 323,
                    IdUsuario = 7,
                },
                new Producto
                {
                    Id = 4,
                    Descripcion = "TV",
                    Costo = 119.28M,
                    PrecioVenta = 562.01M,
                    Stock = 313,
                    IdUsuario = 4,
                },
                new Producto
                {
                    Id = 5,
                    Descripcion = "Notebook HP",
                    Costo = 224.72M,
                    PrecioVenta = 894.97M,
                    Stock = 207,
                    IdUsuario = 10,
                },
                new Producto
                {
                    Id = 6,
                    Descripcion = "Cocina",
                    Costo = 137.36M,
                    PrecioVenta = 507.0M,
                    Stock = 39,
                    IdUsuario = 9,
                },
                new Producto
                {
                    Id = 7,
                    Descripcion = "Parrilla",
                    Costo = 230.29M,
                    PrecioVenta = 486.16M,
                    Stock = 283,
                    IdUsuario = 7,
                },
                new Producto
                {
                    Id = 8,
                    Descripcion = "Auriculares",
                    Costo = 189.95M,
                    PrecioVenta = 961.61M,
                    Stock = 119,
                    IdUsuario = 6,
                },
                new Producto
                { 
                    Id = 9,
                    Descripcion = "Celular",
                    Costo = 180.22M,
                    PrecioVenta = 589.88M,
                    Stock = 316,
                    IdUsuario = 7,
                },
                new Producto
                {
                    Id = 10,
                    Descripcion = "Escritorio de PC",
                    Costo = 180.22M,
                    PrecioVenta = 531.02M,
                    Stock = 208,
                    IdUsuario = 10,
                }
            );
            return modelBuilder;
        }
    }
}
