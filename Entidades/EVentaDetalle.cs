using System;

namespace ProyectoPrueba.Entidades
{
    public class EVentaDetalle
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
        public string Fecha { get; set; }
    }
}
