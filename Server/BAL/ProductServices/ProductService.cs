using DAL.Entities;
using DAL.UnitOfWork;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAL.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public ProductService(IUnitOfWork unitOfWork, ILogger<ProductService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public List<Product> Get(int? skip, int? take)
        {
            var logId = Guid.NewGuid();
            var logSkip = skip.HasValue ? skip.Value.ToString() : "null";
            var logTake = take.HasValue ? take.Value.ToString() : "null";
            _logger.LogDebug($"{logId} Products was requested with parameters: {nameof(skip)} : {logSkip}, {nameof(take)} : {logTake}");

            var products = _unitOfWork.Products.Get(skip, take, product => product.Category);

            var productsCount = products.Count();
            _logger.LogDebug($"{logId} It was found {productsCount} products");

            return products;
        }

        public async Task<CreateProductResponse> CreateAsync(Product product)
        {
            CreateProductResponse response;

            var categoryExists = _unitOfWork.Categories.Any(category => category.Id == product.CategoryId);

            if (!categoryExists)
            {
                _logger.LogWarning($"Category {product.CategoryId} was not found during product creation");

                response = new CreateProductResponse(CreateProductResult.CategoryNotFound);

                return response;
            }

            product = _unitOfWork.Products.Create(product);

            await _unitOfWork
                .SaveAsync()
                .ConfigureAwait(false);

            _logger.LogInformation($"Product {product.Id} was created");

            response = new CreateProductResponse(product);

            return response;
        }

    }
}
