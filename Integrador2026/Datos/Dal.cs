using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2026.Datos
{
    internal class Dal
    {
        public static DataTable EjecutarConsulta(string sql, params SqlParameter[] parametros)
        {
            using var cn = new SqlConnection(Conexion.sConnection);
            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddRange(parametros);
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int EjecutarComando(string sql, params SqlParameter[] parametros)
        {
            using var cn = new SqlConnection(Conexion.sConnection);
            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddRange(parametros);
            cn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}
