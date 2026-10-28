using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2026.Entidades
{
    public class ClienteIndividuo : Cliente
    {
        public string Apellido { get; set; }

        public ClienteIndividuo(string nombre, string apellido, string cuit, string email, string telefono, string direccion) : base (nombre, cuit, email, telefono, direccion)
        {
            Apellido = apellido;
        }
    }
}
}
