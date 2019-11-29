using DAL.Entities;
using DAL.UnitOfWork;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAL.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public CategoryService(IUnitOfWork unitOfWork, ILogger<CategoryService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            var logId = Guid.NewGuid();
            _logger.LogDebug($"{logId} All categories was requested");

            var categories = await _unitOfWork.Categories.GetAsync();

            var categoriesCount = categories.Count();
            _logger.LogDebug($"{logId} It was found {categoriesCount} categories");

            return categories;
        }
    }
}
