using AutoMapper;
using Stories.Dtos;
using Stories.Dtos.Type;
using Stories.Meta;
using Stories.Models;

namespace Stories.Profiles
{
    public class TypesProfile : Profile
    {
        public TypesProfile()
        {
            CreateMap<Type, TypeDto>();
            CreateMap<InsertTypeDto, Type>();
            CreateMap<InsertTypeDto, Type>();
            CreateMap<Type, InsertTypeDto>();
        }
    }
}