using MediatR;
using prueba_tecnica.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace prueba_tecnica.Application.RegisterPersona
{
    public class RegisterPersonaHandler : IRequestHandler<RegisterPersonaCommand, int>
    {
        private readonly IRepository<Persona> repository;

        public RegisterPersonaHandler(IRepository<Persona> repository)
        {
            this.repository = repository;
        }

        public async Task<int> Handle(RegisterPersonaCommand request, CancellationToken cancellationToken)
        {
            Persona persona;

            if (await this.repository.Existe(x => x.DocumentoIdentidad == request.DocumentoIdentidad))
                throw new Exception("no puede exister dos personas con el mismo documento");

            persona = Persona.Bulid(request.DocumentoIdentidad, request.Nombre, request.Apellido, request.FechaNacimiento,
                request.Telefono, request.Correo, request.Direccion);

            await this.repository.Save(persona);
            await this.repository.Commit();
            return 0;
        }
    }
}
