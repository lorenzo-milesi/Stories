using System.Linq;
using AutoMapper;
using Stories.Dtos;
using Stories.Meta;
using Stories.Models;

namespace Stories.Profiles
{
    public class ProjectsProfile : Profile
    {
        public ProjectsProfile()
        {
            CreateMap<Project, ProjectData>().ForMember(
                dest => dest.StoriesCount,
                opt => opt.MapFrom(source => source.Stories.Count())
            );
            CreateMap<ProjectCreateDto, Project>();
            CreateMap<ProjectUpdateDto, Project>();
            CreateMap<Project, ProjectUpdateDto>();
        }
    }
}