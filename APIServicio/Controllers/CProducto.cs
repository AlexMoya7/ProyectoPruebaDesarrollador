using Microsoft.AspNetCore.Mvc;
using ProyectoPrueba.AccesoDatos;
using ProyectoPrueba.Entidades;
using ProyectoPrueba.Negocio;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;


namespace APIServicio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CProducto : ControllerBase
    {
        private readonly SQLHelper _db;
        private readonly IProducto _prod;

        public CProducto(SQLHelper db, IProducto prod) 
        {
            _db = db;
            _prod = prod;
        }

        [HttpGet("test")]
        public ActionResult<string> Test()
        {
            try
            {
                var con = _db.GetConnection() ;
                var cmd = new SqlCommand("SELECT 1", con);
                {
                    var res = cmd.ExecuteScalar();
                    return Ok("Conexión exitosa: " + res);
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Error en la conexion: "+ ex.Message);
            }
        }

        [HttpGet("producto")]
        public ActionResult<List<Producto>> GetProductos() 
        {
            try
            {
                return Ok(_prod.ObtenerProductos());
            }
            catch (Exception e)
            {

                return StatusCode(500, "Error: "+ e.Message);
            }
        }

        [HttpGet("producto/{id}")]
        public ActionResult<Producto> GetProductoId(int id)
        {
            try
            {
                var prod = _prod.ObtenerPorId(id);

                if (prod == null)
                    return NotFound($"No se encontró un producto con id: {id}");

                return Ok(prod);
            }
            catch (Exception e)
            {

                return StatusCode(500, "Error: " + e.Message);
            }
        }

        [HttpGet("producto/existencias/{id}")]
        public ActionResult<int> GetExistencias()
        {
            try
            {
                return Ok(_prod.ObtenerExistencias());
            }
            catch (Exception e)
            {

                return StatusCode(500, "Error: " + e.Message);
            }
        }
    }
}
