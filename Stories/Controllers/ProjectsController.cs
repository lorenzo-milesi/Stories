using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Models;

namespace Stories.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectRepository _repository;

        public ProjectsController(IProjectRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Project>> Index()
        {
            return Ok(_repository.Index());
        }
    }
}