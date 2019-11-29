using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<TEntity> where TEntity: EntityBase
    {
        public Task<List<TEntity>> GetAsync(int? skip = null, int? take = null, params Expression<Func<TEntity, object>>[] includes);

        public Task<TEntity> CreateAsync(TEntity entity);

        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter);
    }
}
