using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SmartUrban.ENT;
using SmartUrban.DAL.Conexion;

namespace SmartUrban.DAL.Repositories
{
    public class UsuarioDAL
    {
        public IEnumerable<Usuario> GetAll()
        {
            var list = new List<Usuario>();
            using (var conn = ConexionDB.GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Usuarios", conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var u = new Usuario();
                        // populate properties as needed
                        list.Add(u);
                    }
                }
            }
            return list;
        }
    }
}
