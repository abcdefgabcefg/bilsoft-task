using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SqlRepository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly DbSet<TEntity> _entities;

        public SqlRepository(DbContext context)
        {
            _entities = context.Set<TEntity>();
        }

        public Task<List<TEntity>> GetAsync(int? skip = null, int? take = null, params Expression<Func<TEntity, object>>[] includes)
        {
            var entities = Include(_entities, includes);

            if (skip.HasValue)
            {
                entities = entities.Skip(skip.Value);
            }

            if (take.HasValue)
            {
                entities = entities.Take(take.Value);
            }

            return entities.ToListAsync();
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            var entry = await _entities.AddAsync(entity); 

            return entry.Entity;
        }

        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter)
        {
            var exists = _entities.AnyAsync(filter);

            return exists;
        }

        private IQueryable<TEntity> Include(IQueryable<TEntity> entities, IEnumerable<Expression<Func<TEntity, object>>> properties)
        {
            foreach (var property in properties)
            {
                entities = entities.Include(property);
            }

            return entities;
        }
    }
}
