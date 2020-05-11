using AutoMapper;
using Stories.Dtos;
using Stories.Meta;
using Stories.Models;

namespace Stories.Profiles
{
    public class StoriesProfile : Profile
    {
        public StoriesProfile()
        {
            CreateMap<Story, StoryData>();
            CreateMap<Project, StoryData>();
            CreateMap<StoryCreateDto, Story>();
            CreateMap<Story, StoryCreateDto>();
        }
    }
}