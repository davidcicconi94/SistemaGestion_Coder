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
        public ActionResult<List<Usuario>> Get() 
        {
            try
            {
                var listaDeUsuarios = UsuarioBussiness.GetUsuarios();
                return Ok(listaDeUsuarios);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);  
            }
        }
    }
}
