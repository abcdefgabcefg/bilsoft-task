using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAL.ProductServices
{
    public interface IProductService
    {
        public List<Product> Get(int? skip, int? take);

        public Task<CreateProductResponse> CreateAsync(Product product);
    }
}
