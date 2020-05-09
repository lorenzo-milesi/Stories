using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Models;

namespace Stories.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;

        public ProjectsController(IProjectRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProjectIndexDto>> Index()
        {
            IEnumerable<Project> projectsCollection = _repository.Index();

            return Ok(_mapper.Map<IEnumerable<ProjectIndexDto>>(projectsCollection));
        }
    }
}