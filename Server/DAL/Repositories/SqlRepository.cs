using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Repositories
{
    public class SqlRepository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly DbSet<TEntity> _entities;

        public SqlRepository(DbContext context)
        {
            _entities = context.Set<TEntity>();
        }

        public List<TEntity> Get(int? skip = null, int? take = null, params Expression<Func<TEntity, object>>[] includes)
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

            return entities.ToList();
        }

        public TEntity Create(TEntity entity)
        {
            entity = _entities.Add(entity).Entity;

            return entity;
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
