using System;
using ProyectoPrueba.Entidades;
using ProyectoPrueba.AccesoDatos;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ProyectoPrueba.Negocio
{
	public class NProducto : IProducto
	{
		private readonly SQLHelper _db;
		public NProducto(SQLHelper db)
		{
			_db = db;
		}

		public List<Producto> ObtenerProductos()
		{
			try
			{
				var lista = new List<Producto>();

				var con = _db.GetConnection() ;
				var cmd = new SqlCommand("SP_ObtenerProducto", con);
				{
					cmd.CommandType = CommandType.StoredProcedure;

					var reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						lista.Add(new Producto()
						{
							Id = reader.GetInt32(reader.GetOrdinal("ID")),
							Titulo = reader.GetString(reader.GetOrdinal("NOMBRE")),
							Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
							PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("PRECIO UNITARIO")),
							Existencias = reader.GetInt32(reader.GetOrdinal("Existencias"))
						});
					}
				}

				return lista;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public Producto ObtenerPorId(int id) 
		{
			try
			{
				Producto prod = new Producto();
            
				var con = _db.GetConnection();
				var cmd = new SqlCommand("SP_ObtenerProductoID", con);
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@ID", id);
					var reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						prod.Id = reader.GetInt32(reader.GetOrdinal("ID"));
						prod.Titulo = reader.GetString(reader.GetOrdinal("NOMBRE"));
						prod.Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"));
						prod.PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("PRECIO UNITARIO"));
						prod.Existencias = reader.GetInt32(reader.GetOrdinal("Existencias"));
					}
				}
				return prod;

			}
			catch (Exception )
			{

				throw;
			}
        }
		public List<Producto> ObtenerExistencias() 
		{
            try
            {
                var lista = new List<Producto>();

                var con = _db.GetConnection();
                var cmd = new SqlCommand("SP_CantidadExistenciaProducto", con);
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lista.Add(new Producto()
                        {
                            //Id = reader.GetInt32(reader.GetOrdinal("ID")),
                            Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                            //Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
                            //PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("PRECIO UNITARIO")),
                            Existencias = reader.GetInt32(reader.GetOrdinal("Existencias"))
                        });
                    }
                }
                return lista;

            }
            catch (Exception )
            {

                throw;
            }
        }
	}
}
