using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGestionData.Migrations
{
    public partial class AddedIdentityId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ventas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductosVendidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    IdVenta = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: true),
                    VentaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosVendidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductosVendidos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductosVendidos_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellido", "Contrasenia", "Mail", "Nombre", "NombreUsuario" },
                values: new object[,]
                {
                    { 1, "Brignall", "sC6%bv.1cQ1.p4IX", "jbrignall0@timesonline.co.uk", "Jae", "jbrignall0" },
                    { 2, "Santora", "wG9@\\XLplgECZN{", "dsantora1@blogspot.com", "Darci", "dsantora1" },
                    { 3, "Godsmark", "rO5}&C$$<e\"$", "lgodsmark2@taobao.com", "Linea", "lgodsmark2" },
                    { 4, "Gaine", "eJ8($/R5*@", "fgaine3@baidu.com", "Faun", "fgaine3" },
                    { 5, "Indgs", "dF5!$f*)P", "mindgs4@senate.gov", "Matt", "mindgs4" },
                    { 6, "Dyers", "fR9@9v%S?D03N(9b", "hdyers5@nature.com", "Hertha", "hdyers5" },
                    { 7, "Cadigan", "uU1#&P3J", "mcadigan6@123-reg.co.uk", "Myrta", "mcadigan6" },
                    { 8, "Cran", "cE6#lOe63p", "ccran7@ow.ly", "Carling", "ccran7" },
                    { 9, "Gilroy", "lW6\\w%5818g", "fgilroy8@liveinternet.ru", "Felicity", "fgilroy8" },
                    { 10, "Grosvenor", "lU9''v`cO", "mgrosvenor9@nature.com", "Marnie", "mgrosvenor9" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Costo", "Descripcion", "IdUsuario", "PrecioVenta", "Stock" },
                values: new object[,]
                {
                    { 1, 175.98m, "Microondas", 10, 543.11m, 333 },
                    { 2, 281.75m, "Heladera", 4, 830.27m, 108 },
                    { 3, 236.55m, "Cama", 7, 848.15m, 323 },
                    { 4, 119.28m, "TV", 4, 562.01m, 313 },
                    { 5, 224.72m, "Notebook HP", 10, 894.97m, 207 },
                    { 6, 137.36m, "Cocina", 9, 507.0m, 39 },
                    { 7, 230.29m, "Parrilla", 7, 486.16m, 283 },
                    { 8, 189.95m, "Auriculares", 6, 961.61m, 119 },
                    { 9, 180.22m, "Celular", 7, 589.88m, 316 },
                    { 10, 180.22m, "Escritorio de PC", 10, 531.02m, 208 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdUsuario",
                table: "Productos",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosVendidos_ProductoId",
                table: "ProductosVendidos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosVendidos_VentaId",
                table: "ProductosVendidos",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_UsuarioId",
                table: "Ventas",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductosVendidos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
