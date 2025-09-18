using System.Collections.Generic;
using ProyectoPrueba.Entidades;

namespace ProyectoPrueba.Negocio
{
	public interface IVenta
	{
        /// <summary>
        /// Obtiene todas las ventas registradas en la base de datos de un producto.
        /// </summary>
        /// <param name="id">Id del producto</param>
        /// <returns>Lista de ventas de un articulo.</returns>
        Venta ObtenerVentasXArticulo(int id);

        /// <summary>
        /// Obtiene todas las ventas registradas en la base de datos.
        /// </summary>
        /// <returns>Lista de ventas globales.</returns>
		List<EVentaDetalle> ObtenerVentasGlobales();

        /// <summary>
        /// Obtiene todos los artículos más vendidos registradas en la base de datos.
        /// </summary>
        /// <returns>Lista de artículos más vendidos.</returns>
		List<EVentaDetalle> ObtenerArticulosMasVendidos();
	}
}
