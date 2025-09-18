using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ProyectoPrueba.AccesoDatos;
using ProyectoPrueba.Entidades;
using ProyectoPrueba.Negocio;

namespace APIServicio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CVenta : ControllerBase
    {
        private readonly SQLHelper _db;
        private readonly IVenta _vta;

        public CVenta(SQLHelper db, IVenta vta)
        {
            _db = db;
            _vta = vta;
        }

        [HttpGet("test")]
        public ActionResult<string> Test()
        {
            try
            {
                var con = _db.GetConnection();
                var cmd = new SqlCommand("SELECT 1", con);
                {
                    var res = cmd.ExecuteScalar();
                    return Ok("Conexión exitosa: " + res);
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Error en la conexion: " + ex.Message);
            }
        }

        [HttpGet("venta/{id}")]
        public ActionResult<Venta> ObtenerVentaXArticulo(int id)
        {
            try
            {
                var vta = _vta.ObtenerVentasXArticulo(id);

                if (vta == null) 
                    return NotFound($"No se encontró un producto con id: {id}");
                
                return Ok(vta);
            }
            catch (Exception e)
            {
                return StatusCode(500,"Error: "+ e.Message);
            }
        }

        [HttpGet("venta-global")]
        public ActionResult<EVentaDetalle> ObtenerVentasGlobales()
        {
            try
            {
                return Ok(_vta.ObtenerVentasGlobales());
            }
            catch (Exception e)
            {

                return StatusCode(500,"Error: "+e.Message);
            }
        }

        [HttpGet("articulos-vendidos")]
        public ActionResult<Venta> ObtenerArticulosMasVendidos()
        {
            try
            {
                return Ok(_vta.ObtenerArticulosMasVendidos());
            }
            catch (Exception e)
            {

                return StatusCode(500,"Error: "+e.Message);
            }
        }
    }
}
