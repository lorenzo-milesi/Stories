using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Dtos.Project;
using Stories.Meta;
using Stories.Models;

namespace Stories.Controllers
{
    public class ProjectsController : AController<
        Project,
        ProjectDto,
        ProjectDto,
        InsertProjectDto>
    {
        public ProjectsController(IRepository<Project> repository, IMapper mapper) : base(repository, mapper)
        {
            Resource = "Projects";
        }

        [HttpGet]
        public new ActionResult<IndexDto<ProjectDto>> Index(int page = 1, int limit = 100)
        {
            return base.Index(page, limit);
        }

        [HttpGet("{id}", Name = "ShowProject")]
        [ProducesResponseType(typeof(ProjectDto), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult<ProjectDto> Show(int id)
        {
            return base.Show(id);
        }

        [HttpPost]
        [ProducesResponseType(typeof(InsertProjectDto), 201)]
        public new ActionResult Create(InsertProjectDto dto)
        {
            Project model = base.Create(dto);

            return CreatedAtRoute(
                "ShowProject",
                new { Id = model.Id },
                Mapper.Map<ProjectDto>(model)
            );
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Update(int id, InsertProjectDto updateDto)
        {
            return base.Update(id, updateDto);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(NoContentResult), 204)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public new ActionResult Patch(int id, JsonPatchDocument<InsertProjectDto> document)
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