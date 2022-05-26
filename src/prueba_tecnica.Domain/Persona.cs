using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_tecnica.Domain
{
    public class Persona : Entity, IAggregate
    {
        public string DocumentoIdentidad { get; private set; }

        public string Nombre { get; private set; }

        public string Apellido { get; private set; }

        public DateTime FechaNacimiento { get; private set; }

        public InformacionContacto InformacionContacto { get; private set; }

        private Persona(string documentoIdentidad, string nombre, string apellido, DateTime fechaNacimiento,
            string telefono, string correo, string direccion):base()
        {
            
            if (String.IsNullOrEmpty(documentoIdentidad))
                throw new Exception("documento obligatorio");
            else if (String.IsNullOrEmpty(nombre))
                throw new Exception("nombre obligatorio");
            else if (String.IsNullOrEmpty(apellido))
                throw new Exception("apellido obligatorio");

            DocumentoIdentidad = documentoIdentidad;
            FechaNacimiento = fechaNacimiento;
            Nombre = nombre;
            Apellido = apellido;

            this.InformacionContacto = new InformacionContacto(telefono, correo, direccion);
        }

        public static Persona Bulid(string documentoIdentidad, string nombre, string apellido, DateTime fechaNacimiento,
            string telefono, string correo, string direccion)
        {
            return new Persona(documentoIdentidad, nombre, apellido, fechaNacimiento, telefono, correo, direccion);
        }

        public void ChangeAttributesMain(string documentoIdentidad, string nombre, string apellido, DateTime fechaNacimiento)
        {
            DocumentoIdentidad = documentoIdentidad;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public void ChangeInformacionContacto(string telefono, string correo, string direccion)
        {
            this.InformacionContacto = new InformacionContacto(telefono, correo, direccion);
        }
    }
}
