using SistemaGestionData.Data;
using SistemaGestionEntities;


namespace SistemaGestionBussiness
{
    public static class ProductoBussiness
    {
        public static List<Producto> GetProductos()
        {
            try
            {
                var listaDeProductos = ProductoData.ListarProductos();
                return listaDeProductos;
            }
            catch(Exception ex) 
            { 
                return new List<Producto>();
            }
        }
    }
}
