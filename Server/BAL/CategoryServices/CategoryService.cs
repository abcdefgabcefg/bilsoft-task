using DAL.Entities;
using DAL.UnitOfWork;
using System.Collections.Generic;

namespace BAL.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Category> GetAll()
        {
            var categories = _unitOfWork.Categories.Get();

            return categories;
        }
    }
}
