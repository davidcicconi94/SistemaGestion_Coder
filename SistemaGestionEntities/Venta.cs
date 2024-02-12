namespace SistemaGestionEntities
{
    public class Venta
    {
        public int Id { get; set; }
        public string? Comentarios { get; set; }
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<ProductoVendido> ProductosVendidos { get; set; } = new HashSet<ProductoVendido>();
    }
}
