
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SistemaGestionEntities
{
    public class ProductoVendido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey(nameof(IdProducto))]
        public int IdProducto { get; set; }
        public int Stock { get; set; }

        [ForeignKey(nameof(IdVenta))]
        public int IdVenta { get; set; }

        public Producto? Producto { get; set; }
        public Venta? Venta { get; set; }
    }
}
