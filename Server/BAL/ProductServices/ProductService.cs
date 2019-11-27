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

        public List<Product> Get(int skipCount, int takeCount)
        {
            var products = _unitOfWork.Products.Get(skipCount, takeCount, product => product.Category);

            return products;
        }
    }
}
