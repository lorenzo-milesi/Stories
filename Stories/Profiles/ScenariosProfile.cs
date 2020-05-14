using AutoMapper;
using Stories.Dtos;
using Stories.Dtos.Scenario;
using Stories.Meta;
using Stories.Models;

namespace Stories.Profiles
{
    public class ScenariosProfile : Profile
    {
        public ScenariosProfile()
        {
            CreateMap<Scenario, ScenarioDto>();
            CreateMap<InsertScenarioDto, Scenario>();
            CreateMap<InsertScenarioDto, Scenario>();
            CreateMap<Scenario, InsertScenarioDto>();
        }
    }
}