using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Abstract.Repositories
{
    public interface IBaseRepository<T>
    {
        Task Create(T entity);
        Task Delete(T entity);
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null);
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task Update(T entity);

    }
}
