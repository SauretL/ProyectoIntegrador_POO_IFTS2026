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
    public static class ProductoDAL
    {

        public static List<Producto> Buscar(string texto)
        {
            string sql = @"SELECT ID_PRODUCTO, NOMBRE, DESCRIPCION, PRECIOCOSTO, MARGEN, IVA,
                                  PROVEEDOR, CATEGORIA, SUBCATEGORIA
                           FROM PRODUCTO
                           WHERE NOMBRE LIKE @t OR DESCRIPCION LIKE @t
                           ORDER BY NOMBRE";
            DataTable dt = Dal.EjecutarConsulta(sql, new SqlParameter("@t", "%" + texto + "%"));

            var lista = new List<Producto>();
            foreach (DataRow r in dt.Rows)
            {
                decimal costo = Convert.ToDecimal(r["PRECIOCOSTO"]);
                decimal margenMonto = Convert.ToDecimal(r["MARGEN"]);
                decimal ivaMonto = Convert.ToDecimal(r["IVA"]);
                decimal bruto = costo + margenMonto;

                double margen = costo == 0 ? 0 : (double)(margenMonto / costo);
                double iva = bruto == 0 ? 0 : (double)(ivaMonto / bruto);

                lista.Add(new Producto(
                    Convert.ToInt32(r["ID_PRODUCTO"]),
                    r["NOMBRE"].ToString(),
                    r["DESCRIPCION"].ToString(),
                    costo,
                    margen,
                    iva,
                    r["PROVEEDOR"].ToString(),
                    r["CATEGORIA"].ToString(),
                    r["SUBCATEGORIA"].ToString()));
            }
            return lista;
        }

        private static SqlParameter[] Parametros(Producto p, bool incluirId)
        {
            // Convierte a dos decimales
            decimal costo = Math.Round(p.PrecioCosto, 2);
            decimal margenMonto = Math.Round(p.PrecioBruto - p.PrecioCosto, 2);
            decimal bruto = costo + margenMonto;
            decimal ivaMonto = Math.Round(p.PrecioVenta - p.PrecioBruto, 2);
            decimal venta = bruto + ivaMonto;

            var l = new List<SqlParameter>
            {
                new SqlParameter("@nombre", p.Nombre),
                new SqlParameter("@desc", p.Descripcion),
                new SqlParameter("@costo", costo),
                new SqlParameter("@margen", margenMonto),
                new SqlParameter("@iva", ivaMonto),
                new SqlParameter("@bruto", bruto),
                new SqlParameter("@venta", venta),
                new SqlParameter("@prov", p.Proveedor),
                new SqlParameter("@cat", p.Categoria),
                new SqlParameter("@subcat", p.SubCategoria)
            };
            if (incluirId) l.Add(new SqlParameter("@id", p.Id));
            return l.ToArray();
        }

        public static int Insertar(Producto p)
        {
            string sql = @"INSERT INTO PRODUCTO (NOMBRE, DESCRIPCION, PRECIOCOSTO, MARGEN, IVA,
                                                 PRECIOBRUTO, PRECIOVENTA, PROVEEDOR, CATEGORIA, SUBCATEGORIA)
                           VALUES (@nombre, @desc, @costo, @margen, @iva, @bruto, @venta, @prov, @cat, @subcat)";
            return Dal.EjecutarComando(sql, Parametros(p, false));
        }

        public static int Modificar(Producto p)
        {
            string sql = @"UPDATE PRODUCTO SET NOMBRE=@nombre, DESCRIPCION=@desc, PRECIOCOSTO=@costo,
                                  MARGEN=@margen, IVA=@iva, PRECIOBRUTO=@bruto, PRECIOVENTA=@venta,
                                  PROVEEDOR=@prov, CATEGORIA=@cat, SUBCATEGORIA=@subcat
                           WHERE ID_PRODUCTO=@id";
            return Dal.EjecutarComando(sql, Parametros(p, true));
        }

        public static int Eliminar(int id)
        {
            return Dal.EjecutarComando("DELETE FROM PRODUCTO WHERE ID_PRODUCTO=@id",
                                       new SqlParameter("@id", id));
        }
    }
}
