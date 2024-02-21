using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVentas")]
        public ActionResult<List<Venta>> Get()
        {
            try
            {
                var ventas = VentaBussiness.GetVentas();
                return Ok(ventas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("ventas/{id}", Name = "GetVentaById")]
        public ActionResult<Venta> GetById(int id)
        {
            try
            {
                var venta = VentaBussiness.GetVenta(id);

                if (venta != null)
                {
                    return Ok(venta);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "CreateVenta")]
        public ActionResult<Venta> Create([FromBody] List<Producto> productos, int usuarioId)
        {
            try
            {
                if (productos == null || productos.Count == 0 || usuarioId <= 0)
                {
                    return BadRequest("La solicitud es inválida. Asegúrate de proporcionar una lista de productos y un IdUsuario válido.");
                }

                VentaBussiness.CrearVenta(productos, usuarioId);

                return Ok("Venta cargada exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut(Name = "ModifyVenta")]
        public ActionResult<Venta> Modify([FromBody] Venta ventaMod)
        {
            try
            {
                VentaBussiness.ModificarVenta(ventaMod);
                return Ok(ventaMod);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteVenta")]
        public ActionResult<Venta> Delete(int id)
        {
            try
            {
                VentaBussiness.EliminarVenta(id);
                return Ok($"Venta eliminada de Id: {id}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
