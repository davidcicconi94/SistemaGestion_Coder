﻿namespace SistemaGestionEntities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public float Costo { get; set; }
        public float PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public virtual ICollection<ProductoVendido> ProductosVendidos { get; set; } = new List<ProductoVendido>();
    }
}
