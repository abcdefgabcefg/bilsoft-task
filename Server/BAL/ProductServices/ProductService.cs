using DAL.Entities;
using DAL.UnitOfWork;
using System.Collections.Generic;

namespace BAL.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Product> Get(int? skip, int? take)
        {
            var products = _unitOfWork.Products.Get(skip, take, product => product.Category);

            return products;
        }

        public CreateProductResponse Create(Product product)
        {
            CreateProductResponse response;

            var categoryExists = _unitOfWork.Categories.Any(category => category.Id == product.CategoryId);

            if (!categoryExists)
            {
                response = new CreateProductResponse(CreateProductResult.CategoryNotFound);

                return response;
            }

            product = _unitOfWork.Products.Create(product);

            _unitOfWork.Save();

            response = new CreateProductResponse(product);

            return response;
        }

    }
}
