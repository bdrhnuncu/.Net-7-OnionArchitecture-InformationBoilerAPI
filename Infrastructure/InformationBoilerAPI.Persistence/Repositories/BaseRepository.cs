using InformationBoilerAPI.Application.Abstract.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Persistence.Repositories
{
    public class BaseRepository<T, Context> : IBaseRepository<T>
        where T : class, new()
        where Context : DbContext, new()
    {
        public async Task Create(T entity)
        {
            using (var cntxt = new Context())
            {
                var add = cntxt.Entry(entity);
                add.State = EntityState.Added;
                await cntxt.SaveChangesAsync();
            }
        }

        public async Task Delete(T entity)
        {
            using (var cntxt = new Context())
            {
                var delete = cntxt.Entry(entity);
                delete.State = EntityState.Deleted;
                await cntxt.SaveChangesAsync();
            }
        }

        public async Task<T> Get(Expression<Func<T, bool>> filter)
        {
            using (var cntxt = new Context())
            {
                return await cntxt.Set<T>().FirstOrDefaultAsync(filter);
            }
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var cntx = new Context())
            {
                return filter == null
                    ? await cntx.Set<T>().ToListAsync()
                    : await cntx.Set<T>().Where(filter).ToListAsync();
            }
        }

        public async Task Update(T entity)
        {
            using (var cntx = new Context())
            {
                var update = cntx.Entry(entity);
                update.State = EntityState.Modified;
                await cntx.SaveChangesAsync();
            }
        }
    }
}
