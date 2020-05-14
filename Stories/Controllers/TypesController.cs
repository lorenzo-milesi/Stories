using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Dtos.Type;
using Stories.Meta;
using Stories.Models;

namespace Stories.Controllers
{
    public class TypesController : AController<
        Type,
        TypeDto,
        TypeDto,
        InsertTypeDto>
    {
        public TypesController(IRepository<Type> repository, IMapper mapper) : base(repository, mapper)
        {
            Resource = "Types";
        }

        [HttpGet]
        public new ActionResult<IndexDto<TypeDto>> Index(int page = 1, int limit = 100)
        {
            return base.Index(page, limit);
        }

        [HttpGet("{id}", Name = "ShowType")]
        [ProducesResponseType(typeof(TypeDto), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult<TypeDto> Show(int id)
        {
            return base.Show(id);
        }

        [HttpPost]
        [ProducesResponseType(typeof(InsertTypeDto), 201)]
        public new ActionResult Create(InsertTypeDto dto)
        {
            Type model = base.Create(dto);

            return CreatedAtRoute(
                "ShowType",
                new { Id = model.Id },
                Mapper.Map<TypeDto>(model)
            );
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Update(int id, InsertTypeDto updateDto)
        {
            return base.Update(id, updateDto);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Patch(int id, JsonPatchDocument<InsertTypeDto> document)
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