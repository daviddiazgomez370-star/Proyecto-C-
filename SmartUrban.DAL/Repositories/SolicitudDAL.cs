using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SmartUrban.ENT;
using SmartUrban.DAL.Conexion;

namespace SmartUrban.DAL.Repositories
{
    public class SolicitudDAL
    {
        public IEnumerable<Solicitud> GetAll()
        {
            var list = new List<Solicitud>();
            using (var conn = ConexionDB.GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Solicitudes", conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var so = new Solicitud();
                        list.Add(so);
                    }
                }
            }
            return list;
        }
    }
}
