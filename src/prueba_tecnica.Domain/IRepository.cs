using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace prueba_tecnica.Domain
{
    public interface IRepository<T> where T: IAggregate  
    {
        public Task Save(T obj);

        public Task Commit();

        public Task Update(T obj);

        public Task<T> Get(Expression<Func<T, bool>> expression);

        public Task<bool> Existe(Expression<Func<T, bool>> expression);
    }
}
