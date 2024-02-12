using SistemaGestionData.Data;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        public static List<Usuario> GetUsuarios()
        {
            try
            {
                List<Usuario> listaDeUsuarios = UsuarioData.ListarUsuarios();
                return listaDeUsuarios;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);   
                return new List<Usuario>() { };
            }
        }
    }
}
