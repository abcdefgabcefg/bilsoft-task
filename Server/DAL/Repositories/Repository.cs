using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private DbSet<TEntity> _entities;

        public Repository(DbContext context)
        {
            _entities = context.Set<TEntity>();
        }

        public List<TEntity> Get(int? skipCount = null, int? takeCount = null, params Expression<Func<TEntity, object>>[] includes)
        {
            var entities = Include(_entities, includes);

            if (skipCount.HasValue)
            {
                entities = entities.Skip(skipCount.Value);
            }

            if (takeCount.HasValue)
            {
                entities = entities.Take(takeCount.Value);
            }

            return entities.ToList();
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
