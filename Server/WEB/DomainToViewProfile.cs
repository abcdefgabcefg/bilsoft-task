using AutoMapper;
using DAL.Entities;
using WEB.Models;

namespace WEB
{
    public class DomainToViewProfile : Profile
    {
        public DomainToViewProfile()
        {
            CreateMap<Product, GetProduct>()
                .ForMember(getProduct => getProduct.Category, opt => opt.MapFrom(product => product.Category.Title));
        }
    }
}
