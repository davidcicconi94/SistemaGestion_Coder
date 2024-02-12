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

                if(listaDeUsuarios.Count > 0)
                {
                    return Ok(listaDeUsuarios);
                }
                else
                {
                    return NotFound();
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);  
            }
        }

        [HttpGet("usuarios/{id}", Name = "GetUsuarioById")]
        public ActionResult<Usuario> GetById(int id)
        {
            try
            {
                var usuario = UsuarioBussiness.GetUsuario(id);

                if(usuario != null)
                {
                    return Ok(usuario);
                }
                else
                {
                    return NotFound();
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "CreateUsuario")]
        public ActionResult<Usuario> Create([FromBody] Usuario usuario)
        {
            try
            {
                UsuarioBussiness.CrearUsuario(usuario);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut(Name = "ModifyUsuario")]
        public ActionResult<Usuario> Modify([FromBody] Usuario usuarioModificado)
        {
            try
            {
                UsuarioBussiness.ModificarUsuario(usuarioModificado);
                return Ok(usuarioModificado);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteUsuario")]
        public ActionResult<Usuario> DeleteUsuario(int id) 
        {
            try
            {
                UsuarioBussiness.EliminarUsuario(id);
                return Ok($"Usuario eliminado de Id: {id}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
