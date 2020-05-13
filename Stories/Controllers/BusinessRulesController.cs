using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Meta;
using Stories.Models;

namespace Stories.Controllers
{
    public class BusinessRulesController : AController<
        BusinessRule,
        BusinessRuleData,
        BusinessRuleData,
        BusinessRuleCreateDto,
        BusinessRuleCreateDto>
    {
        public BusinessRulesController(IRepository<BusinessRule> repository, IMapper mapper) : base(repository, mapper)
        {
            Resource = "BusinessRules";
        }

        [HttpGet]
        public new ActionResult<IndexDto> Index(int page = 1, int limit = 100)
        {
            return base.Index(page, limit);
        }

        [HttpGet("{id}", Name = "ShowBusinessRule")]
        [ProducesResponseType(typeof(ShowDto), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult<ShowDto> Show(int id)
        {
            return base.Show(id);
        }

        [HttpPost]
        [ProducesResponseType(typeof(BusinessRuleCreateDto), 201)]
        public new ActionResult Create(BusinessRuleCreateDto createDto)
        {
            BusinessRule model = base.Create(createDto);

            return CreatedAtRoute(
                "ShowBusinessRule",
                new { Id = model.Id },
                new ShowDto(Mapper.Map<BusinessRuleData>(model)));
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Update(int id, BusinessRuleCreateDto updateDto)
        {
            return base.Update(id, updateDto);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Patch(int id, JsonPatchDocument<BusinessRuleCreateDto> document)
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