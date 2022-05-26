using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_tecnica.Application.RegisterPersona
{
    public class RegisterPersonaCommand : IRequest<int>
    {
        public string DocumentoIdentidad { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string Direccion { get; set; }
    }
}
