using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d => d.ProductBrand, options => options.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType, options => options.MapFrom(s => s.ProductType.Name))
                .ForMember(d => d.PictureUrl, options => options.MapFrom<ProductUrlResolver>());
        }
    }
}