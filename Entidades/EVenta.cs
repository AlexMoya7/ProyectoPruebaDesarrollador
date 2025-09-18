using System;

namespace ProyectoPrueba.Entidades
{
	public class Venta
	{
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int CantidadVendida { get; set; }
        public DateTime Fecha { get; set; }
    }
}
