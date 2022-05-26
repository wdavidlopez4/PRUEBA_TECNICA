using prueba_tecnica.Application.RegisterPersona;
using prueba_tecnica.Domain;
using prueba_tecnica.Infrastructure.Persistence;
using System;
using System.Threading.Tasks;

namespace prueba_tecnica.ConsoleApp
{
    /// <summary>
    /// la capa de presentacion se ubiera implementado en MVC pero por tiempo no se pudo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //configuracion IOC
            IRepository<Persona> repos = new SQLRepository<Persona>();

            //ejecucion comando
            RegisterPersonaCommand command = new RegisterPersonaCommand();
            RegisterPersonaHandler handler = new RegisterPersonaHandler(repos);

            var rest = Task.FromResult(handler.Handle(command, new System.Threading.CancellationToken()).Result);

            Console.WriteLine(rest);
        }
    }
}
