using System.Linq;
using AutoMapper;
using Stories.Dtos.Project;
using Stories.Models;

namespace Stories.Profiles
{
    public class ProjectsProfile : Profile
    {
        public ProjectsProfile()
        {
            CreateMap<Project, ProjectDto>().ForMember(
                dest => dest.StoriesCount,
                opt => opt.MapFrom(source => source.Stories.Count())
            );
            CreateMap<Project, ProjectWithStoriesDto>().ForMember(
                dest => dest.StoriesCount,
                opt => opt.MapFrom(source => source.Stories.Count())
            );
            CreateMap<InsertProjectDto, Project>();
            CreateMap<Project, InsertProjectDto>();
            CreateMap<Project, ProjectDto>();
        }
    }
}