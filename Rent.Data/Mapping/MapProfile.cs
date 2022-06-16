using AutoMapper;
using Rent.Entites.Dto;
using Rent.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Data.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Sparepart, SparepartDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Sparepart, CreateSparepartDto>()
                .ForMember(des => des.Categories, opt =>
                opt.MapFrom(src => src.CategorySpareparts.Select(x => new CreateCategorySparepartDto { CategoryId = x.CategoryId, SparepartId = x.SparepartId }
                ))).ReverseMap();

            CreateMap<Category, GetCategoryListProduct>()
                .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(x => x.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(x => x.Spareparts, opt => opt.MapFrom(src => src.CategorySpareparts.Select(x => x.Sparepart.Name)));
        }
    }
}
