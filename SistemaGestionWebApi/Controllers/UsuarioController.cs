using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController: ControllerBase
    {
        [HttpGet(Name = "GetClientes")] 
        public IEnumerable<Usuario> Get() 
        {
            return UsuarioBussiness.GetUsuarios().ToArray();
        }
    }
}
