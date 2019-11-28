using AutoMapper;
using DAL.Entities;
using WEB.Models;

namespace WEB
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Product, GetProduct>()
                .ForMember(getProduct => getProduct.Category, opt => opt.MapFrom(product => product.Category.Title));

            CreateMap<PostProduct, Product>()
                .ForMember(product => product.Category, opt => opt.Ignore())
                .ForMember(product => product.CategoryId, opt => opt.MapFrom(postProduct => postProduct.Category));
        }
    }
}
