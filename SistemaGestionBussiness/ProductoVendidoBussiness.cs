using SistemaGestionData.Data;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> GetProductosVendidos()
        {
            try
            {
                var listaDeProductosVendidos = ProductoVendidoData.ListarProductosVendidos();
                return listaDeProductosVendidos;
            }
            catch (Exception e)
            {
                return new List<ProductoVendido>();
            }
        }
    }
}
