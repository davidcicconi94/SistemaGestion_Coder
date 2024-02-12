using SistemaGestionData.Data;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        public static List<Usuario>  GetUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }

        public static Usuario GetUsuario(int id) 
        {
            return UsuarioData.ObtenerUsuario(id);
        }

        public static void CrearUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }

        public static void ModificarUsuario(Usuario usuarioModificado)
        {
            UsuarioData.ModificarUsuarios(usuarioModificado);
        }

        public static void EliminarUsuario(int id)
        {
            UsuarioData.EliminarUsuario(id);
        }
    }
}
