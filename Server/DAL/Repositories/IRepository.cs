using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DAL.Repositories
{
    public interface IRepository<TEntity> where TEntity: EntityBase
    {
        public List<TEntity> Get(int? skip = null, int? take = null, params Expression<Func<TEntity, object>>[] includes);
    }
}
