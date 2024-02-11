using SistemaGestionData.Data;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        public static List<Usuario> GetUsuarios()
        {
            try
            {
                List<Usuario> listaDeUsuarios = UsuarioData.GetUsuarios();
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
