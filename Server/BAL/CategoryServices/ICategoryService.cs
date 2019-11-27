using DAL.Entities;
using System.Collections.Generic;

namespace BAL.CategoryServices
{
    public interface ICategoryService
    {
        public List<Category> GetAll();
    }
}
