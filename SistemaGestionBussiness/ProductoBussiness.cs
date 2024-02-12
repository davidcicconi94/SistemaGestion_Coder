using SistemaGestionData.Data;
using SistemaGestionEntities;


namespace SistemaGestionBussiness
{
    public static class ProductoBussiness
    {
        public static List<Producto> GetProductos()
        {
            return ProductoData.ListarProductos();
        }

        public static Producto GetProducto(int id)
        {
            return ProductoData.ObtenerProducto(id);
        }

        public static void CrearProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }

        public static void ModificarProducto(Producto productoModificado)
        {
            ProductoData.ModificarProducto(productoModificado);
        }

        public static void EliminarProducto(int id)
        {
            ProductoData.EliminarProducto(id);
        }
    }
}
