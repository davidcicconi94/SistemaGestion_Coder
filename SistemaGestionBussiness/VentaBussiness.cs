using SistemaGestionData.Data;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        public static List<Venta> GetVentas()
        {
            try
            {
                var listaDeVentas = VentaData.ListarVentas();
                return listaDeVentas;
            }
            catch(Exception ex)
            {
                return new List<Venta>();
            }
        }
    }
}
