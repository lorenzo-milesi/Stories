using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Models;

namespace Stories.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class StoriesController : ControllerBase
    {
        private readonly IRepository<Story> _repository;
        private readonly IMapper _mapper;

        public StoriesController(IRepository<Story> storiesRepository, IMapper mapper)
        {
            _repository = storiesRepository;
            _mapper = mapper;
        }
    }
}