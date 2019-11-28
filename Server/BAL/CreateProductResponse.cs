using DAL.Entities;

namespace BAL
{
    public class CreateProductResponse
    {
        public CreateProductResult Result { get; }

        public Product Product { get; }

        public CreateProductResponse(CreateProductResult result)
        {
            Result = result;
        }

        public CreateProductResponse(Product product)
        {
            Result = CreateProductResult.Success;
            Product = product;
        }
    }
}
