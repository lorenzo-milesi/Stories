using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Dtos.State;
using Stories.Meta;
using Stories.Models;

namespace Stories.Controllers
{
    public class StatesController : AController<
        State,
        StateDto,
        StateDto,
        InsertStateDto>
    {
        public StatesController(IRepository<State> repository, IMapper mapper) : base(repository, mapper)
        {
            Resource = "States";
        }

        [HttpGet]
        public new ActionResult<IndexDto<StateDto>> Index(int page = 1, int limit = 100)
        {
            return base.Index(page, limit);
        }

        [HttpGet("{id}", Name = "ShowState")]
        [ProducesResponseType(typeof(StateDto), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult<StateDto> Show(int id)
        {
            return base.Show(id);
        }

        [HttpPost]
        [ProducesResponseType(typeof(InsertStateDto), 201)]
        public new ActionResult Create(InsertStateDto dto)
        {
            State model = base.Create(dto);

            return CreatedAtRoute(
                "ShowType",
                new { Id = model.Id },
                Mapper.Map<StateDto>(model)
            );
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Update(int id, InsertStateDto updateDto)
        {
            return base.Update(id, updateDto);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Patch(int id, JsonPatchDocument<InsertStateDto> document)
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