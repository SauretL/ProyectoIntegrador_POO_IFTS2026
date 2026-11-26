using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Integrador2026.Datos
{
    public static class UsuarioDAL
    {
        public static bool Validar(string login, string password)
        {
            string sql = @"SELECT 1 FROM USUARIO
                           WHERE LOGIN = @login
                             AND PASSW COLLATE Latin1_General_CS_AS = @pass
                             AND (FCH_BAJA IS NULL OR FCH_BAJA > GETDATE())";
            DataTable dt = Dal.EjecutarConsulta(sql,
                new SqlParameter("@login", login),
                new SqlParameter("@pass", password));
            return dt.Rows.Count > 0;
        }
    }
}
