using DAL.Entities;
using System.Collections.Generic;

namespace BAL.ProductServices
{
    public interface IProductService
    {
        public List<Product> Get(int? skip, int? take);

        public CreateProductResponse Create(Product product);
    }
}
