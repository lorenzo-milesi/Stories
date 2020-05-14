using AutoMapper;
using Stories.Dtos;
using Stories.Dtos.Project;
using Stories.Dtos.Story;
using Stories.Meta;
using Stories.Models;

namespace Stories.Profiles
{
    public class StoriesProfile : Profile
    {
        public StoriesProfile()
        {
            CreateMap<Story, StoryDto>();
            CreateMap<Story, IndexStoryDto>();
            CreateMap<ProjectDto, StoryDto>();
            CreateMap<InsertStoryDto, Story>();
            CreateMap<Story, InsertStoryDto>();
        }
    }
}