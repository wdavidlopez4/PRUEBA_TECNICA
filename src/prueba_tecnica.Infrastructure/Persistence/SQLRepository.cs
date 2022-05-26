using prueba_tecnica.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace prueba_tecnica.Infrastructure.Persistence
{
    /// <summary>
    /// toda la persistencia y el llamado al context en este caso no lo implemento por temas de tiempo 
    /// de la prueba
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SQLRepository<T> : IRepository<T> where T : IAggregate
    {
        public Task Commit()
        {
            Console.WriteLine("sql ejecutado.");
            return Task.CompletedTask;
        }

        public Task<T> Get(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task Save(T obj)
        {
            Console.WriteLine("sql ejecutado.");
            return Task.CompletedTask;
        }

        public Task Update(T obj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Existe(Expression<Func<T, bool>> expression)
        {
            Console.WriteLine("sql ejecutado.");
            return Task.FromResult(true);
        }
    }
}
