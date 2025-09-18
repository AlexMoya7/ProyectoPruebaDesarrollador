using Microsoft.Data.SqlClient;
using ProyectoPrueba.AccesoDatos;
using ProyectoPrueba.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ProyectoPrueba.Negocio
{
	public class NVenta : IVenta
	{
		private readonly SQLHelper _db;
		public NVenta(SQLHelper db)
		{
			_db = db;
		}

		public Venta ObtenerVentasXArticulo(int id)
		{
			try
			{
				var vta = new Venta();

				var con = _db.GetConnection();
				var cmd = new SqlCommand("SP_VentasXArticulo", con);
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@Id", id);

					var reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						vta.IdProducto = reader.GetInt32(reader.GetOrdinal("IdProducto"));
						vta.CantidadVendida = reader.GetInt32(reader.GetOrdinal("CANTIDAD VENTA"));
                        vta.Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"));
					}
				}

				return vta;
			}
			catch (Exception e)
			{

				throw e;
			}
		}
		public List<EVentaDetalle> ObtenerVentasGlobales()
		{
			try
			{
				var lista = new List<EVentaDetalle>();

				var con = _db.GetConnection();
				var cmd = new SqlCommand("SP_VentasTotales",con);
                {
                    cmd.CommandType = CommandType.StoredProcedure;

					var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(new EVentaDetalle
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("ID")),
                            Nombre = reader.GetString(reader.GetOrdinal("NOMBRE")),
                            Cantidad = reader.GetInt32(reader.GetOrdinal("CANTIDAD")),
                            PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("PRECIO")),
                            Total = reader.GetDecimal(reader.GetOrdinal("TOTAL")),
                            Fecha = reader.GetString(reader.GetOrdinal("FECHA"))
                        });
                    }
                }

                return lista;
            }
			catch (Exception e)
			{

				throw e;
			}
		}
        public List<EVentaDetalle> ObtenerArticulosMasVendidos()
		{
            try
            {
                var lista = new List<EVentaDetalle>();

                var con = _db.GetConnection();
                var cmd = new SqlCommand("SP_TopVentas", con);
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(new EVentaDetalle
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("ID")),
                            Nombre = reader.GetString(reader.GetOrdinal("NOMBRE")),
                            Cantidad = reader.GetInt32(reader.GetOrdinal("CANTIDAD")),
                            PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("PRECIO")),
                            Total = reader.GetDecimal(reader.GetOrdinal("TOTAL")),
                            Fecha = reader.GetString(reader.GetOrdinal("FECHA"))
                        });
                    }
                }

                return lista;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
