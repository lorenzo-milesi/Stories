using AutoMapper;
using Stories.Dtos;
using Stories.Meta;
using Stories.Models;

namespace Stories.Profiles
{
    public class BusinessRulesProfile : Profile
    {
        public BusinessRulesProfile()
        {
            CreateMap<BusinessRule, BusinessRuleData>();
            CreateMap<BusinessRuleCreateDto, BusinessRule>();
            CreateMap<BusinessRuleCreateDto, BusinessRule>();
            CreateMap<BusinessRule, BusinessRuleCreateDto>();
        }
    }
}