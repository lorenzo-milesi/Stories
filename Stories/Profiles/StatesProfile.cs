using AutoMapper;
using Stories.Dtos;
using Stories.Dtos.State;
using Stories.Meta;
using Stories.Models;

namespace Stories.Profiles
{
    public class StatesProfile : Profile
    {
        public StatesProfile()
        {
            CreateMap<State, StateDto>();
            CreateMap<InsertStateDto, State>();
            CreateMap<InsertStateDto, State>();
            CreateMap<State, InsertStateDto>();
        }
    }
}