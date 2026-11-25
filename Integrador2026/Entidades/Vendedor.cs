using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2026.Entidades
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string CUIT { get; set; }
        public Vendedor(int id, string nombre, string apellido, string dni, string cuit)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            CUIT = cuit;
        }
    }
}
