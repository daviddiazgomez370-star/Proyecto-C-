using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SmartUrban.ENT;
using SmartUrban.DAL.Conexion;

namespace SmartUrban.DAL.Repositories
{
    public class ServicioDAL
    {
        public IEnumerable<Servicio> GetAll()
        {
            var list = new List<Servicio>();
            using (var conn = ConexionDB.GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Servicios", conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var s = new Servicio();
                        list.Add(s);
                    }
                }
            }
            return list;
        }
    }
}
