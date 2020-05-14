using AutoMapper;
using Stories.Dtos.BusinessRule;
using Stories.Meta;
using Stories.Models;

namespace Stories.Profiles
{
    public class BusinessRulesProfile : Profile
    {
        public BusinessRulesProfile()
        {
            CreateMap<BusinessRule, BusinessRuleDto>();
            CreateMap<InsertBusinessRuleDto, BusinessRule>();
            CreateMap<BusinessRule, InsertBusinessRuleDto>();
            CreateMap<BusinessRule, IndexBusinessRuleDto>();
        }
    }
}