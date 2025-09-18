using System.Data;
using Microsoft.Data.SqlClient;

namespace ProyectoPrueba.AccesoDatos
{
    public class SQLHelper
    {
        private readonly string _connectionString;

        public SQLHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Devuelve una conexión SqlConnection abierta lista para usar.
        /// El que la usa es responsable de cerrarla o envolverla en un "using".
        /// </summary>
        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}