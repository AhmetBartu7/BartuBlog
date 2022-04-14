using Core.Abstract;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class BaseRepository<TEntity>: IBaseRepository<TEntity> where TEntity: class,IEntity
    {
        private readonly DbContext context;
        public BaseRepository(DbContext _context)
        {
            context = _context;
        }

        public async Task Add(TEntity entity)
        {
           await context.Set<TEntity>().AddAsync(entity);
        }

        public async Task Delete(Expression<Func<TEntity, bool>> where)
        {
            context.Set<TEntity>().Remove(await GetByFirst(where));
        }

        public async Task<IList<TEntity>> GetAll(Expression<Func<TEntity, bool>> where = null, params Expression<Func<TEntity, object>>[] includeTable)
        {
            IQueryable<TEntity> Query = null;
            if (where != null)
            {
                Query = context.Set<TEntity>().Where(where);
            }
            else
            {
                Query = context.Set<TEntity>();
            }
            if (includeTable.Any())
            {
                foreach (var item in includeTable)
                {
                    Query = Query.Include(item);
                }
            }
            return await Query.ToListAsync();
        }

        public async Task<TEntity> GetByFirst(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeTable)
        {
            IQueryable<TEntity> query = context.Set<TEntity>();
            return await query.Where(where).SingleOrDefaultAsync();
        }

        public async Task Update(TEntity entity)
        {
          await Task.Run(() => { context.Set<TEntity>().Update(entity); });
        }
    }
}
