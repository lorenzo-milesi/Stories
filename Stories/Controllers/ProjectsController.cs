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
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase, IController
    {
        private readonly IRepository<Project> _repository;
        private readonly IMapper _mapper;

        public ProjectsController(IRepository<Project> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IndexDto> Index(int page = 1, int limit = 100)
        {
            int offset = (page - 1) * limit;
            IEnumerable<Project> projectsCollection = _repository.Index(offset, limit);

            int count = _repository.Count();
            IndexMeta meta = new IndexMeta { Page = page, Limit = limit, Count = count, Resource = "Projects" };
            IEnumerable<ProjectData> data = _mapper.Map<IEnumerable<ProjectData>>(projectsCollection);
            IndexDto dto = new IndexDto(data, meta);

            return Ok(dto);
        }

        [HttpGet("{id}", Name = "ShowProject")]
        [ProducesResponseType(typeof(ShowDto), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public ActionResult<ShowDto> Show(int id)
        {
            Project project = _repository.Find(id);

            if (project == null)
            {
                return NotFound();
            }

            ProjectData data = _mapper.Map<ProjectData>(project);

            return Ok(new ShowDto(data));
        }

        [HttpPost]
        [ProducesResponseType(typeof(ProjectCreateDto), 201)]
        public ActionResult<Project> Create(ProjectCreateDto projectCreateDto)
        {
            Project project = _mapper.Map<Project>(projectCreateDto);
            _repository.Insert(project);
            _repository.Store();

            return CreatedAtRoute(
                nameof(Show),
                new { Id = project.Id },
                new ShowDto(_mapper.Map<ProjectData>(project)));
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public ActionResult Update(int id, ProjectUpdateDto projectUpdateDto)
        {
            Project project = _repository.Find(id);

            if (project == null)
            {
                return NotFound();
            }

            _mapper.Map(projectUpdateDto, project);
            _repository.Update(project);
            _repository.Store();

            return NoContent();
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public ActionResult Patch(int id, JsonPatchDocument<ProjectUpdateDto> document)
        {
            Project project = _repository.Find(id);

            if (project == null)
            {
                return NotFound();
            }

            ProjectUpdateDto projectToPatch = _mapper.Map<ProjectUpdateDto>(project);
            document.ApplyTo(projectToPatch, ModelState);
            if (!TryValidateModel(projectToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(projectToPatch, project);
            _repository.Update(project);
            _repository.Store();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public ActionResult Delete(int id)
        {
            Project project = _repository.Find(id);

            if (project == null)
            {
                return NotFound();
            }

            _repository.Delete(project);
            _repository.Store();

            return NoContent();
        }
    }
}