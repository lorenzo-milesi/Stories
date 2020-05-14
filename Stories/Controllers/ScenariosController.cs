using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Dtos.Scenario;
using Stories.Meta;
using Stories.Models;

namespace Stories.Controllers
{
    public class ScenariosController : AController<
        Scenario,
        ScenarioDto,
        ScenarioDto,
        InsertScenarioDto>
    {
        public ScenariosController(IRepository<Scenario> repository, IMapper mapper) : base(repository, mapper)
        {
            Resource = "Scenarios";
        }

        [HttpGet]
        public new ActionResult<IndexDto<ScenarioDto>> Index(int page = 1, int limit = 100)
        {
            return base.Index(page, limit);
        }

        [HttpGet("{id}", Name = "ShowScenario")]
        [ProducesResponseType(typeof(ScenarioDto), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult<ScenarioDto> Show(int id)
        {
            return base.Show(id);
        }

        [HttpPost]
        [ProducesResponseType(typeof(InsertScenarioDto), 201)]
        public new ActionResult Create(InsertScenarioDto dto)
        {
            Scenario model = base.Create(dto);

            return CreatedAtRoute(
                "ShowScenario",
                new { Id = model.Id },
                Mapper.Map<ScenarioDto>(model)
            );
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Update(int id, InsertScenarioDto updateDto)
        {
            return base.Update(id, updateDto);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Patch(int id, JsonPatchDocument<InsertScenarioDto> document)
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