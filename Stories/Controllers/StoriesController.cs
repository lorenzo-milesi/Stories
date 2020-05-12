using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Meta;
using Stories.Models;

namespace Stories.Controllers
{
    public class StoriesController : AController<Story, StoryData, StoryCreateDto, StoryCreateDto>
    {
        public StoriesController(IRepository<Story> repository, IMapper mapper) : base(repository, mapper)
        {
            Resource = "Stories";
        }

        [HttpGet]
        public new ActionResult<IndexDto> Index(int page = 1, int limit = 100)
        {
            return base.Index(page, limit);
        }

        [HttpGet("{id}", Name = "ShowStory")]
        [ProducesResponseType(typeof(ShowDto), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult<ShowDto> Show(int id)
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
        [ProducesResponseType(typeof(StoryCreateDto), 201)]
        public new ActionResult Create(StoryCreateDto createDto)
        {
            Story model = base.Create(createDto);

            return CreatedAtRoute(
                "ShowStory",
                new { Id = model.Id },
                new ShowDto(Mapper.Map<StoryData>(model)));
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Update(int id, StoryCreateDto updateDto)
        {
            return base.Update(id, updateDto);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Patch(int id, JsonPatchDocument<StoryCreateDto> document)
        {
            return base.Patch(id, document);
        }
    }
}