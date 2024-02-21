using SistemaGestionData.Data;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        public static List<Venta> GetVentas()
        {
            return VentaData.ListarVentas();
        }

        public static Venta? GetVenta(int id)
        {
            return VentaData.ObtenerVenta(id);
        }

        public static void CrearVenta(List<Producto> productos, int idUsuario)
        {
            VentaData.CrearVenta(productos, idUsuario);
        }

        public static void ModificarVenta(Venta ventaMod)
        {
            VentaData.ModificarVenta(ventaMod);
        }

        public static void EliminarVenta(int id)
        {
            VentaData.EliminarVenta(id);
        }
    }
}
