using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "GetProductos")]
        public ActionResult<List<Producto>> Get()
        {
            try
            {
                var productos = ProductoBussiness.GetProductos();
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("productos/{id}", Name = "GetProductoById")]
        public ActionResult<Producto> GetById(int id)
        {
            try
            {
                var producto = ProductoBussiness.GetProducto(id);

                if (producto != null)
                {
                    return Ok(producto);
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

        [HttpPost(Name = "CreateProducto")]
        public ActionResult<Producto> Create([FromBody] Producto producto)
        {
            try
            {
                ProductoBussiness.CrearProducto(producto);
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut(Name = "ModifyProducto")]
        public ActionResult<Producto> Modify([FromBody] Producto productoMod)
        {
            try
            {
                ProductoBussiness.ModificarProducto(productoMod);
                return Ok(productoMod);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteProducto")]
        public ActionResult<Producto> Delete(int id)
        {
            try
            {
                ProductoBussiness.EliminarProducto(id);
                return Ok($"Producto eliminado de Id: {id}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
