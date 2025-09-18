
namespace ProyectoPrueba.Entidades.DTO
{ 
	public class EVentaDto
	{
        public Id { get; set; }
        public int IdProducto { get; set; }
        public string ProductoNombre { get; set; }
        public int CantidadVendida { get; set; }
        public Datetime Fecha { get; set; }
        public decimal Total { get; set; }
    }
}
