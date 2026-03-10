using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SmartUrban.ENT;
using SmartUrban.DAL.Conexion;

namespace SmartUrban.DAL.Repositories
{
    public class ProveedorDAL
    {
        public IEnumerable<Proveedor> GetAll()
        {
            var list = new List<Proveedor>();
            using (var conn = ConexionDB.GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Proveedores", conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var p = new Proveedor();
                        list.Add(p);
                    }
                }
            }
            return list;
        }
    }
}
