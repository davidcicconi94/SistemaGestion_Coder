using SistemaGestionData.Context;
using SistemaGestionData.Exceptions;
using SistemaGestionEntities;

namespace SistemaGestionData.Data
{
    public static class UsuarioData
    {
        public static List<Usuario> ListarUsuarios()
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var listaDeUsuarios = context.Usuarios?.ToList();

                    if (listaDeUsuarios.Count == 0)
                    {
                        throw new ListNotFoundException<Usuario>(
                            listaDeUsuarios,
                            "Lista de usuarios Vacía "
                        );
                    }

                    return listaDeUsuarios;
                }
                catch (ListNotFoundException<Usuario> ex)
                {
                    if (ex.Data.Contains("ListaVacia") && (bool)ex.Data["ListaVacia"])
                    {
                        Console.WriteLine("La lista de usuarios se encuentra vacía");
                    }
                    else
                    {
                        Console.WriteLine($"Error General:", ex.Message);
                    }
                    throw; // Busca el catch nuevamente
                }
            }
        }

        public static Usuario ObtenerUsuario(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var usuarioEncontrado = context.Usuarios?.FirstOrDefault(u => u.Id == id);

                    if (usuarioEncontrado != null)
                    {
                        return usuarioEncontrado;
                    }
                    else
                    {
                        throw new InvalidOperationException($"No se encontró usuario con el ID: {id}");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocurrió un error al obtener el usuario. Consulta los registros para obtener más detalles.", ex);
                }
            }
        }

        public static bool CrearUsuario(Usuario usuario)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    context.Usuarios?.Add(usuario);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible crear un usuario: {ex.Message}");
                    return false;
                }
            }
        }

        public static void ModificarUsuarios(Usuario usuarioMod)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var usuarioExistente = context.Usuarios?.FirstOrDefault(p => p.Id == usuarioMod.Id);

                    if (usuarioExistente != null)
                    {
                        usuarioExistente.Nombre = usuarioMod.Nombre;
                        usuarioExistente.Apellido = usuarioMod.Apellido;
                        usuarioExistente.NombreUsuario = usuarioMod.NombreUsuario;
                        usuarioExistente.Contrasenia = usuarioMod.Contrasenia;

                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible modificar un usuario: {ex.Message}");
                    return;
                }
            }
        }

        public static void EliminarUsuario(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var usuarioEncontrado = context.Usuarios?.Find(id);

                    if (usuarioEncontrado != null)
                    {
                        context.Usuarios?.Remove(usuarioEncontrado);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible eliminar el usuario: {ex.Message}");
                    return;
                }
            }
        }
    }
}
