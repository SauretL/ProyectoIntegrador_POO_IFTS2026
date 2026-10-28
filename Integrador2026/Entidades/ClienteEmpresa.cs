using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2026.Entidades
{
    public class ClienteEmpresa : Cliente
    {
        public string Contacto { get; set; }
    
        public ClienteEmpresa(string nombre, string contacto, string cuit, string email, string telefono, string direccion) : base(nombre, cuit, email, telefono, direccion)
        {
            Contacto = contacto;
        }
    }
}
