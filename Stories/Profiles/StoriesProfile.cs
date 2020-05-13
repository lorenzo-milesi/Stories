using AutoMapper;
using Stories.Dtos;
using Stories.Meta;
using Stories.Meta.Relationships;
using Stories.Models;

namespace Stories.Profiles
{
    public class StoriesProfile : Profile
    {
        public StoriesProfile()
        {
            CreateMap<Story, StoryData>();
            CreateMap<Story, StoryIndexData>();
            CreateMap<Project, StoryData>();
            CreateMap<StoryCreateDto, Story>();
            CreateMap<Story, StoryCreateDto>();
            CreateMap<Story, StoryInBusinessRuleData>();
        }
    }
}