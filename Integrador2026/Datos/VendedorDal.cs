using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Microsoft.Data.SqlClient;
using Integrador2026.Entidades;

namespace Integrador2026.Datos
{
    public static class VendedorDAL
    {
        public static List<Vendedor> Buscar(string texto)
        {
            string sql = @"SELECT ID_VENDEDOR, NOMBRE, APELLIDO, DNI, CUIT FROM VENDEDOR
                           WHERE NOMBRE LIKE @t OR APELLIDO LIKE @t OR DNI LIKE @t
                           ORDER BY APELLIDO";
            DataTable dt = Dal.EjecutarConsulta(sql, new SqlParameter("@t", "%" + texto + "%"));

            var lista = new List<Vendedor>();
            foreach (DataRow r in dt.Rows)
                lista.Add(new Vendedor(Convert.ToInt32(r["ID_VENDEDOR"]), r["NOMBRE"].ToString(),
                                       r["APELLIDO"].ToString(), r["DNI"].ToString(), r["CUIT"].ToString()));
            return lista;
        }

        public static bool ExisteDni(string dni, int idExcluir)
        {
            DataTable dt = Dal.EjecutarConsulta(
                "SELECT 1 FROM VENDEDOR WHERE DNI=@dni AND ID_VENDEDOR<>@id",
                new SqlParameter("@dni", dni), new SqlParameter("@id", idExcluir));
            return dt.Rows.Count > 0;
        }

        public static int Insertar(Vendedor v)
        {
            return Dal.EjecutarComando(
                "INSERT INTO VENDEDOR (NOMBRE, APELLIDO, DNI, CUIT) VALUES (@n, @a, @dni, @cuit)",
                new SqlParameter("@n", v.Nombre), new SqlParameter("@a", v.Apellido),
                new SqlParameter("@dni", v.DNI), new SqlParameter("@cuit", v.CUIT));
        }

        public static int Modificar(Vendedor v)
        {
            return Dal.EjecutarComando(
                "UPDATE VENDEDOR SET NOMBRE=@n, APELLIDO=@a, DNI=@dni, CUIT=@cuit WHERE ID_VENDEDOR=@id",
                new SqlParameter("@n", v.Nombre), new SqlParameter("@a", v.Apellido),
                new SqlParameter("@dni", v.DNI), new SqlParameter("@cuit", v.CUIT),
                new SqlParameter("@id", v.Id));
        }

        public static int Eliminar(int id)
        {
            return Dal.EjecutarComando("DELETE FROM VENDEDOR WHERE ID_VENDEDOR=@id",
                                       new SqlParameter("@id", id));
        }
    }
}
