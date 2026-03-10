using System;
using System.Data.SqlClient;

namespace SmartUrban.DAL.Conexion
{
    public static class ConexionDB
    {
        // Placeholder connection string — update to your environment or use configuration
        public static string ConnectionString { get; } = "Data Source=.;Initial Catalog=SmartUrbanDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
