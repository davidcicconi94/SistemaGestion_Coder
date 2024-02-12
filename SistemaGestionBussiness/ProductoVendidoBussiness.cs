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
        public static List<ProductoVendido>? GetProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }

        public static ProductoVendido? GetProductoVendido(int id)
        {
            return ProductoVendidoData.ObtenerProductoVendido(id);
        }

        public static void CrearProductoVendido(ProductoVendido producto)
        {
            ProductoVendidoData.CrearProductoVendido(producto);
        }

        public static void ModificarProductoVendido(ProductoVendido productoModificado)
        {
            ProductoVendidoData.ModificarProductoVendido(productoModificado);
        }

        public static void EliminarProductoVendido(int id)
        {
            ProductoVendidoData.EliminarProductoVendido(id);
        }
    }
}
