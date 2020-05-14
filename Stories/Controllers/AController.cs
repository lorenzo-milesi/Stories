using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Stories.Data;
using Stories.Dtos;
using Stories.Meta;

namespace Stories.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class AController<TModel, TDto, TIndexDto, TInsertDto> : ControllerBase
        where TModel : class
        where TDto : class
        where TInsertDto : class
    {
        protected readonly IRepository<TModel> Repository;
        protected readonly IMapper Mapper;
        protected string Resource;

        protected AController(IRepository<TModel> repository, IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }

        protected ActionResult<IndexDto<TIndexDto>> Index(int page = 1, int limit = 100)
        {
            int offset = (page - 1) * limit;
            IEnumerable<TModel> projectsCollection = Repository.Index(offset, limit);

            int count = Repository.Count();
            IndexMeta meta = new IndexMeta { Page = page, Limit = limit, Count = count, Resource = Resource };
            IEnumerable<TIndexDto> data = Mapper.Map<IEnumerable<TIndexDto>>(projectsCollection);
            IndexDto<TIndexDto> dto = new IndexDto<TIndexDto>(data, meta);

            return Ok(dto);
        }

        protected ActionResult<TDto> Show(int id)
        {
            TModel model = Repository.Find(id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<TDto>(model));
        }

        protected TModel Create(TInsertDto createDto)
        {
            TModel model = Mapper.Map<TModel>(createDto);
            Repository.Insert(model);
            Repository.Store();

            return model;
        }

        protected ActionResult Update(int id, TInsertDto updateDto)
        {
            TModel model = Repository.Find(id);

            if (model == null)
            {
                return NotFound();
            }

            Mapper.Map(updateDto, model);
            Repository.Update(model);
            Repository.Store();

            return NoContent();
        }

        protected ActionResult Patch(int id, JsonPatchDocument<TInsertDto> document)
        {
            TModel model = Repository.Find(id);

            if (model == null)
            {
                return NotFound();
            }

            TInsertDto modelToPatch = Mapper.Map<TInsertDto>(model);
            document.ApplyTo(modelToPatch, ModelState);
            if (!TryValidateModel(modelToPatch))
            {
                return ValidationProblem(ModelState);
            }

            Mapper.Map(modelToPatch, model);
            Repository.Update(model);
            Repository.Store();

            return NoContent();
        }

        protected ActionResult Delete(int id)
        {
            TModel model = Repository.Find(id);

            if (model == null)
            {
                return NotFound();
            }

            Repository.Delete(model);
            Repository.Store();

            return NoContent();
        }
    }
}