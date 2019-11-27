using DAL.Entities;
using DAL.Repositories;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IRepository<Product> Products { get; }
        
        public IRepository<Category> Categories { get; }

        public int Save();
    }
}
