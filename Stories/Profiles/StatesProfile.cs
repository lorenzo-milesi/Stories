using AutoMapper;
using Stories.Dtos;
using Stories.Meta;
using Stories.Models;

namespace Stories.Profiles
{
    public class StatesProfile : Profile
    {
        public StatesProfile()
        {
            CreateMap<State, StateData>();
            CreateMap<StateCreateDto, State>();
            CreateMap<StateCreateDto, State>();
            CreateMap<State, StateCreateDto>();
        }
    }
}