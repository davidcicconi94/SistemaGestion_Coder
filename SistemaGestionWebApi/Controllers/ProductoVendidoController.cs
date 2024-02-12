using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductosVendidos")]
        public ActionResult<List<ProductoVendido>> Get()
        {
            try
            {
                var productosVend = ProductoVendidoBussiness.GetProductosVendidos();
                return Ok(productosVend);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("productos-vendidos/{id}", Name = "GetProductoVendidoById")]
        public ActionResult<ProductoVendido> GetById(int id)
        {
            try
            {
                var productoVend = ProductoVendidoBussiness.GetProductoVendido(id);

                if (productoVend != null)
                {
                    return Ok(productoVend);
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

        [HttpPost(Name = "CreateProductoVendidos")]
        public ActionResult<ProductoVendido> Create([FromBody] ProductoVendido productoVend)
        {
            try
            {
                ProductoVendidoBussiness.CrearProductoVendido(productoVend);
                return Ok(productoVend);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut(Name = "ModifyProductoVendido")]
        public ActionResult<ProductoVendido> Modify([FromBody] ProductoVendido productoVendMod)
        {
            try
            {
                ProductoVendidoBussiness.ModificarProductoVendido(productoVendMod);
                return Ok(productoVendMod);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteProductoVendido")]
        public ActionResult<ProductoVendido> Delete(int id)
        {
            try
            {
                ProductoVendidoBussiness.EliminarProductoVendido(id);
                return Ok($"Producto vendido eliminado de Id: {id}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
