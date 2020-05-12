using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Meta;
using Stories.Models;

namespace Stories.Controllers
{
    public class TypesController : AController<Type, TypeData, TypeCreateDto, TypeCreateDto>
    {
        public TypesController(IRepository<Type> repository, IMapper mapper) : base(repository, mapper)
        {
            Resource = "Types";
        }

        [HttpGet]
        public new ActionResult<IndexDto> Index(int page = 1, int limit = 100)
        {
            return base.Index(page, limit);
        }

        [HttpGet("{id}", Name = "ShowType")]
        [ProducesResponseType(typeof(ShowDto), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult<ShowDto> Show(int id)
        {
            return base.Show(id);
        }

        [HttpPost]
        [ProducesResponseType(typeof(TypeCreateDto), 201)]
        public new ActionResult Create(TypeCreateDto createDto)
        {
            Type model = base.Create(createDto);

            return CreatedAtRoute(
                "ShowType",
                new { Id = model.Id },
                new ShowDto(Mapper.Map<TypeData>(model)));
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Update(int id, TypeCreateDto updateDto)
        {
            return base.Update(id, updateDto);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Patch(int id, JsonPatchDocument<TypeCreateDto> document)
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