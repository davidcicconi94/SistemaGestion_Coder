using SistemaGestionData.Context;
using SistemaGestionData.Exceptions;
using SistemaGestionEntities;

namespace SistemaGestionData.Data
{
    public class ProductoVendidoData
    {
        public static List<ProductoVendido>? ListarProductosVendidos()
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var listaDeProductosVendidos = context.ProductosVendidos?.ToList();

                    if (listaDeProductosVendidos.Count == 0)
                    {
                        throw new ListNotFoundException<ProductoVendido>(
                            listaDeProductosVendidos,
                            "Lista de productos vendidos Vacía "
                        );
                    }
                    return listaDeProductosVendidos;
                }
                catch (Exception ex)
                {
                    Console.Write($"Productos vendidos no encontrados: {ex.Message}");
                    return null;
                }
            }
        }

        public static ProductoVendido? ObtenerProductoVendido(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var productoVendidoEncontrado = context.ProductosVendidos?.FirstOrDefault(x =>
                        x.Id == id
                    );

                    if (productoVendidoEncontrado != null)
                    {
                        return productoVendidoEncontrado;
                    }
                    else
                    {
                        return null; 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Producto vendido no encontrado: {ex.Message}");
                    return null;
                }
            }
        }
        public static void CrearProductoVendido(ProductoVendido nuevoProductoVendido)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    context.Add(nuevoProductoVendido);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible crear un producto vendido: {ex.Message}");
                    return;
                }
            }
        }

        public static void ModificarProductoVendido(ProductoVendido productoVendidoMod)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var productoVendido = context.ProductosVendidos?.FirstOrDefault(p => p.Id == productoVendidoMod.Id);

                    if (productoVendido != null)
                    {
                        productoVendido.IdProducto = productoVendido.IdProducto;
                        productoVendido.IdVenta = productoVendido.IdVenta;
                        productoVendido.Stock = productoVendido.Stock;

                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible modificar un producto vendido: {ex.Message}");
                    return ;
                }
            }
        }

        public static void EliminarProductoVendido(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var productoVendidoEncontrado = context.ProductosVendidos?.Find(id);

                    if (productoVendidoEncontrado != null)
                    {
                        context.ProductosVendidos?.Remove(productoVendidoEncontrado);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible eliminar un producto vendido: {ex.Message}");
                    return;
                }
            }
        }
    }
}
