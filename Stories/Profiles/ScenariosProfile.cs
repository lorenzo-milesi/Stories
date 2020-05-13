using AutoMapper;
using Stories.Dtos;
using Stories.Meta;
using Stories.Models;

namespace Stories.Profiles
{
    public class ScenariosProfile : Profile
    {
        public ScenariosProfile()
        {
            CreateMap<Scenario, ScenarioData>();
            CreateMap<ScenarioCreateDto, Scenario>();
            CreateMap<ScenarioCreateDto, Scenario>();
            CreateMap<Scenario, ScenarioCreateDto>();
        }
    }
}