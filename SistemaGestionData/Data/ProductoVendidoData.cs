using SistemaGestionData.Context;
using SistemaGestionData.Exceptions;
using SistemaGestionEntities;

namespace SistemaGestionData.Data
{
    public class ProductoVendidoData
    {
        public static List<ProductoVendido> ListarProductosVendidos()
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
                    return new List<ProductoVendido>();
                }
            }
        }

        public static bool ObtenerProductoVendido(int id)
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
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Producto vendido no encontrado: {ex.Message}");
                    return false;
                }
            }
        }
        public static bool CrearProductoVendido(ProductoVendido nuevoProductoVendido)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    context.Add(nuevoProductoVendido);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible crear un producto vendido: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool ModificarProductoVendido(int id, ProductoVendido productoVendidoMod)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var productoVendido = context.ProductosVendidos?.Find(id);

                    if (productoVendido != null)
                    {
                        productoVendido.IdProducto = productoVendido.IdProducto;
                        productoVendido.IdVenta = productoVendido.IdVenta;
                        productoVendido.Stock = productoVendido.Stock;

                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(
                        $"No fue posible modificar un producto vendido: {ex.Message}"
                    );
                    return false;
                }
            }
        }

        public static bool EliminarProductoVendido(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var productoVendidoEncontrado = context.ProductosVendidos?.Find(id);

                    if (productoVendidoEncontrado != null)
                    {
                        context.ProductosVendidos?.Remove(productoVendidoEncontrado);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible eliminar un producto vendido: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
