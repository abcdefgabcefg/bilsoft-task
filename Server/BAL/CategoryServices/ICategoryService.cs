using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAL.CategoryServices
{
    public interface ICategoryService
    {
        public Task<List<Category>> GetAllAsync();
    }
}
