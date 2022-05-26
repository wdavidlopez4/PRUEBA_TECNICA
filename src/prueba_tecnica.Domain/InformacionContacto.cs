using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_tecnica.Domain
{
    public class InformacionContacto : Entity
    {
        public string Telefono { get; private set; }

        public string Correo { get; private set; }

        public List<string> Direccion { get; private set; }

        internal InformacionContacto(string telefono, string correo, string direccion)
        {
            Telefono = telefono;
            Correo = correo;
            Direccion.Add(direccion);
        }

        internal void AddDireccion(string direccion)
        {
            this.Direccion.Add(direccion);
        }
    }
}
