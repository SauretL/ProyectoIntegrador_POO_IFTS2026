using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2026.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen {  get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto {
            get { return PrecioCosto + PrecioCosto * (decimal)Margen; }
            }
        public decimal PrecioVenta {
            get { return PrecioBruto + PrecioBruto * (decimal)IVA; }
            }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, double iva, string proveedor, string categoria, string subcategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;
            IVA = iva;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subcategoria;
        }

    }
}
