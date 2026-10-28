using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2026.Entidades
{
    public abstract class Cliente
    {
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Cliente(string nombre, string cuit, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            CUIT = cuit;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
