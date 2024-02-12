using SistemaGestionData.Context;
using SistemaGestionData.Exceptions;
using SistemaGestionEntities;

namespace SistemaGestionData.Data
{
    public class ProductoData
    {
        public static List<Producto> ListarProductos()
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var listaDeProductos = context.Productos?.ToList();

                    if (listaDeProductos.Count == 0)
                    {
                        throw new ListNotFoundException<Producto>(
                            listaDeProductos,
                            "Lista de productos Vacía "
                        );
                    }

                    return listaDeProductos;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Productos no encontrados: {ex.Message}");
                    return new List<Producto>();
                }
            }
        }

        public static bool ObtenerProducto(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var productoEncontrado = context.Productos?.FirstOrDefault(p => p.Id == id);

                    if (productoEncontrado != null)
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
                    Console.WriteLine($"Producto no encontrado: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool CrearProducto(Producto nuevoProducto)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    context.Productos?.Add(nuevoProducto);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible crear un producto: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool ModificarProducto(int id, Producto productoMod)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var productoExistente = context.Productos?.FirstOrDefault(x => x.Id == id);

                    if (productoExistente != null)
                    {
                        productoExistente.Descripcion = productoMod.Descripcion;
                        productoExistente.PrecioVenta = productoMod.PrecioVenta;
                        productoExistente.Stock = productoMod.Stock;
                        productoExistente.Costo = productoMod.Costo;
                        productoExistente.IdUsuario = productoMod.IdUsuario;

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
                    Console.WriteLine($"No fue posible modificar un producto: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool EliminarProducto(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var productoAEliminar = context.Productos?.FirstOrDefault(x => x.Id == id);

                    if (productoAEliminar != null)
                    {
                        context.Productos?.Remove(productoAEliminar);
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
                    Console.WriteLine($"No fue posible eliminar un producto: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
