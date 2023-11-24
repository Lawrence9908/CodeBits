using AutoMapper;
using CodeBits.API.Entities;
using CodeBits.API.Models.Dtos;

namespace CodeBits.API.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Category, AddCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, ViewCategoryDto>().ReverseMap();
        }
    }
}
