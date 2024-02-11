using Microsoft.EntityFrameworkCore;
using SistemaGestionData.Context;
using SistemaGestionData.Exceptions;
using SistemaGestionEntities;

namespace SistemaGestionData.Data
{
    public static class UsuarioData
    {
        public static List<Usuario> GetUsuarios()
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    List<Usuario> listaDeUsuarios = context.Usuarios.ToList();

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
    }
}
