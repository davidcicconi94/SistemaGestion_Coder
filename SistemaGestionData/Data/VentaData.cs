using SistemaGestionData.Context;
using SistemaGestionData.Exceptions;
using SistemaGestionEntities;

namespace SistemaGestionData.Data
{
    public static class VentaData
    {
        public static List<Venta> ListarVentas()
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var listaDeVentas = context.Ventas?.ToList();

                    if (listaDeVentas.Count == 0)
                    {
                        throw new ListNotFoundException<Venta>(
                            listaDeVentas,
                            "Lista de ventas Vacía "
                        );
                    }

                    return listaDeVentas;
                }
                catch (Exception ex)
                {
                    return new List<Venta>();
                }
            }
        }
        public static bool ObtenerVenta(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var ventaEncontrada = context.Ventas?.Find(id);

                    if (ventaEncontrada != null)
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
                    Console.WriteLine($"Venta no encontrada: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool CrearVenta(Venta ventaCreada)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    context.Ventas?.Add(ventaCreada);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible crear una venta: {ex.Message}");
                    return false;
                }
            }
        }
        public static bool ModificarVenta(int id, Venta ventaMod)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var ventaExistente = context.Ventas?.Find(id);

                    if (ventaExistente != null)
                    {
                        ventaExistente.Comentarios = ventaMod.Comentarios;
                        ventaExistente.IdUsuario = ventaMod.IdUsuario;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible modificar una venta: {ex.Message}");
                    return false;
                }
            }
        }
        public static bool EliminarVenta(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var ventaExistente = context.Ventas?.Find(id);

                    if (ventaExistente != null)
                    {
                        context.Ventas?.Remove(ventaExistente);
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
