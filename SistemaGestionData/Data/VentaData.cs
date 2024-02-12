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
                            "Lista de ventas Vacía."
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
        public static Venta? ObtenerVenta(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var ventaEncontrada = context.Ventas?.Find(id);

                    if (ventaEncontrada != null)
                    {
                        return ventaEncontrada;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Venta no encontrada: {ex.Message}");
                    return null;
                }
            }
        }

        public static void CrearVenta(Venta ventaCreada)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    context.Ventas?.Add(ventaCreada);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible crear una venta: {ex.Message}");
                }
            }
        }
        public static void ModificarVenta(Venta ventaMod)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var ventaExistente = context.Ventas?.FirstOrDefault(p => p.Id == ventaMod.Id);

                    if (ventaExistente != null)
                    {
                        ventaExistente.Comentarios = ventaMod.Comentarios;
                        ventaExistente.IdUsuario = ventaMod.IdUsuario;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible modificar una venta: {ex.Message}");
                    return;
                }
            }
        }
        public static void EliminarVenta(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var ventaExistente = context.Ventas?.Find(id);

                    if (ventaExistente != null)
                    {
                        context.Ventas?.Remove(ventaExistente);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible eliminar un producto: {ex.Message}");
                    return;
                }
            }
        }
    }

}
