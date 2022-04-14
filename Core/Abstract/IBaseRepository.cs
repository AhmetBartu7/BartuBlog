using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Abstract
{
    public interface IBaseRepository<TEntity> where TEntity : class,IEntity
    {
       Task<TEntity> GetByFirst(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[]includeTable);
        Task<IList<TEntity>> GetAll(Expression<Func<TEntity, bool>> where = null, params Expression<Func<TEntity, object>>[] includeTable);

        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(Expression<Func<TEntity, bool>> where);


    }
}
