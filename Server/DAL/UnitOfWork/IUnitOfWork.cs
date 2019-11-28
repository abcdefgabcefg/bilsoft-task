using DAL.Entities;
using DAL.Repositories;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IRepository<Product> Products { get; }
        
        public IRepository<Category> Categories { get; }

        public Task<int> SaveAsync();
    }
}
