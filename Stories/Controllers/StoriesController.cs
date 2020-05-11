using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Meta;
using Stories.Models;

namespace Stories.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class StoriesController : ControllerBase, IController
    {
        private readonly IRepository<Story> _repository;
        private readonly IMapper _mapper;

        public StoriesController(IRepository<Story> storiesRepository, IMapper mapper)
        {
            _repository = storiesRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IndexDto> Index(int page = 1, int limit = 100)
        {
            int offset = (page - 1) * limit;
            IEnumerable<Story> stories = _repository.Index(offset, limit);

            int count = _repository.Count();
            IndexMeta meta = new IndexMeta { Page = page, Limit = limit, Count = count, Resource = "Projects" };
            IEnumerable<StoryData> data = _mapper.Map<IEnumerable<StoryData>>(stories);
            IndexDto dto = new IndexDto(data, meta);

            return Ok(dto);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ShowDto), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public ActionResult<ShowDto> Show(int id)
        {
            Story story = _repository.Find(id);

            if (story == null)
            {
                return NotFound();
            }

            StoryData data = _mapper.Map<StoryData>(story);

            return Ok(new ShowDto(data));
        }
    }
}