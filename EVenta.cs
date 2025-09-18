
namespace ProyectoPrueba.Entidades
{
	public class Venta
	{
        public Id { get; set; }
        public int IdProducto { get; set; }
        public int CantidadVendida { get; set; }
        public Datetime Fecha { get; set; }
    }
}
