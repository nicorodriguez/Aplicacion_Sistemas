using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Aplicacion_Sistemas.Repositories
{
    public interface IBaseRepository<T>
    {
        Task SaveAsync();
        Task<IEnumerable<T>> FindAll();
        Task<T> FindById(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        bool Exists(Expression<Func<T, bool>> predicate);
    }
}
