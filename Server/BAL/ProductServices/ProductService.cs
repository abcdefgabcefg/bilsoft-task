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
    }
}
