using AutoMapper;
using BlogsWebApi.Contracts.Responce;
using Domain.Entities;

namespace BlogsWebApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Article, ArticleResponce>()
               .ForMember(resp => resp.Id, config => config.MapFrom(art => art.Id))
               .ForMember(resp => resp.Title, config => config.MapFrom(art => art.Title))
               .ForMember(resp => resp.DateCreate, config => config.MapFrom(art => art.DateCreate))
               .ForMember(resp => resp.DateUpdate, config => config.MapFrom(art => art.DateUpdate))
               .ForMember(resp => resp.Text, config => config.MapFrom(art => art.Text))
               .ForMember(resp => resp.CountView, config => config.MapFrom(art => art.CountView))
               .ForMember(resp => resp.CountLike, config => config.MapFrom(art => art.CountLike))
               .ForMember(resp => resp.Author, config => config.MapFrom(art => $"{art.Author.User.FirstName} {art.Author.User.LastName}"))
               .ForMember(resp => resp.Tags, config => config.MapFrom(art => string.Concat(art.Tags.Select(t=> t.Name))));
        }
    }
}
