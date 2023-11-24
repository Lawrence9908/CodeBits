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
            CreateMap<Comment, AddCommentDto>().ReverseMap();
            CreateMap<Comment, UpdateCommentDto>().ReverseMap();
            CreateMap<Comment, ViewCommentDto>().ReverseMap();
            CreateMap<Article, AddArticleDto>().ReverseMap();
            CreateMap<Article, UpdateArticleDto>().ReverseMap();
            CreateMap<Article, ViewArticlerDto>().ReverseMap();
            CreateMap<UserDto, AppUser>().ReverseMap();
        }
    }
}
