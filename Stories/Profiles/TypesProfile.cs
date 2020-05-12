using AutoMapper;
using Stories.Dtos;
using Stories.Meta;
using Stories.Models;

namespace Stories.Profiles
{
    public class TypesProfile : Profile
    {
        public TypesProfile()
        {
            CreateMap<Type, TypeData>();
            CreateMap<TypeCreateDto, Type>();
            CreateMap<TypeCreateDto, Type>();
            CreateMap<Type, TypeCreateDto>();
        }
    }
}