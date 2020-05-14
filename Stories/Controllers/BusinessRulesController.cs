using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Dtos.BusinessRule;
using Stories.Meta;
using Stories.Models;

namespace Stories.Controllers
{
    public class BusinessRulesController : AController<
        BusinessRule,
        BusinessRuleDto,
        IndexBusinessRuleDto,
        InsertBusinessRuleDto>
    {
        public BusinessRulesController(IRepository<BusinessRule> repository, IMapper mapper) : base(repository, mapper)
        {
            Resource = "BusinessRules";
        }

        [HttpGet]
        public new ActionResult<IndexDto<IndexBusinessRuleDto>> Index(int page = 1, int limit = 100)
        {
            return base.Index(page, limit);
        }

        [HttpGet("{id}", Name = "ShowBusinessRule")]
        [ProducesResponseType(typeof(BusinessRuleDto), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult<BusinessRuleDto> Show(int id)
        {
            return base.Show(id);
        }

        [HttpPost]
        [ProducesResponseType(typeof(InsertBusinessRuleDto), 201)]
        public new ActionResult Create(InsertBusinessRuleDto dto)
        {
            BusinessRule model = base.Create(dto);

            return CreatedAtRoute(
                "ShowBusinessRule",
                new { Id = model.Id },
                Mapper.Map<BusinessRuleDto>(model)
            );
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Update(int id, InsertBusinessRuleDto updateDto)
        {
            return base.Update(id, updateDto);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Patch(int id, JsonPatchDocument<InsertBusinessRuleDto> document)
        {
            return base.Patch(id, document);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Delete(int id)
        {
            return base.Delete(id);
        }
    }
}