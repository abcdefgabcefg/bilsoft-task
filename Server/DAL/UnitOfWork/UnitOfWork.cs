using DAL.Entities;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public IRepository<Product> Products { get; }

        public IRepository<Category> Categories { get; }

        public UnitOfWork(DbContext context)
        {
            _context = context;

            Products = new SqlRepository<Product>(_context);
            Categories = new SqlRepository<Category>(context);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
