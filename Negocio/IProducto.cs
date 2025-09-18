using System.Collections.Generic;
using ProyectoPrueba.Entidades;


namespace ProyectoPrueba.Negocio
{
    public interface IProducto
    {
        /// <summary>
        /// Obtiene todos los productos registrados en la base de datos.
        /// </summary>
        /// <returns>Lista de productos.</returns>
        List<Producto> ObtenerProductos();

        /// <summary>
        /// Obtiene un producto específico por su Id.
        /// </summary>
        /// <param name="id">Id del producto</param>
        /// <returns>El producto si existe, de lo contrario null.</returns>
        Producto ObtenerPorId(int id);

        /// <summary>
        /// Obtiene las existencias de un producto.
        /// </summary>
        /// <param name="id">Id del producto</param>
        List<Producto> ObtenerExistencias();
    }
}
