using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Dtos.Story;
using Stories.Meta;
using Stories.Models;

namespace Stories.Controllers
{
    public class StoriesController : AController<
        Story,
        StoryDto,
        IndexStoryDto,
        InsertStoryDto>
    {
        public StoriesController(IRepository<Story> repository, IMapper mapper) : base(repository, mapper)
        {
            Resource = "Stories";
        }

        [HttpGet]
        public new ActionResult<IndexDto<IndexStoryDto>> Index(int page = 1, int limit = 100)
        {
            return base.Index(page, limit);
        }

        [HttpGet("{id}", Name = "ShowStory")]
        [ProducesResponseType(typeof(StoryDto), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult<StoryDto> Show(int id)
        {
            return base.Show(id);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Delete(int id)
        {
            return base.Delete(id);
        }

        [HttpPost]
        [ProducesResponseType(typeof(InsertStoryDto), 201)]
        public new ActionResult Create(InsertStoryDto dto)
        {
            Story model = base.Create(dto);

            return CreatedAtRoute(
                "ShowStory",
                new { Id = model.Id },
                Mapper.Map<StoryDto>(model)
            );
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Update(int id, InsertStoryDto updateDto)
        {
            return base.Update(id, updateDto);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Patch(int id, JsonPatchDocument<InsertStoryDto> document)
        {
            return base.Patch(id, document);
        }
    }
}