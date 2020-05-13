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
    public abstract class AController<TModel, TData, TIndexData, TCreate, TUpdate> : ControllerBase
        where TModel : class
        where TData : IModelData
        where TCreate : class, new()
        where TUpdate : class
    {
        protected readonly IRepository<TModel> Repository;
        protected readonly IMapper Mapper;
        protected string Resource;

        protected AController(IRepository<TModel> repository, IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }

        protected ActionResult<IndexDto> Index(int page = 1, int limit = 100)
        {
            int offset = (page - 1) * limit;
            IEnumerable<TModel> projectsCollection = Repository.Index(offset, limit);

            int count = Repository.Count();
            IndexMeta meta = new IndexMeta { Page = page, Limit = limit, Count = count, Resource = Resource };
            IEnumerable<TIndexData> data = Mapper.Map<IEnumerable<TIndexData>>(projectsCollection);
            IndexDto dto = new IndexDto(data, meta);

            return Ok(dto);
        }

        protected ActionResult<ShowDto> Show(int id)
        {
            TModel model = Repository.Find(id);

            if (model == null)
            {
                return NotFound();
            }

            TData data = Mapper.Map<TData>(model);

            return Ok(new ShowDto(data));
        }

        protected TModel Create(TCreate createDto)
        {
            TModel model = Mapper.Map<TModel>(createDto);
            Repository.Insert(model);
            Repository.Store();

            return model;
        }

        protected ActionResult Update(int id, TUpdate updateDto)
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

        protected ActionResult Patch(int id, JsonPatchDocument<TUpdate> document)
        {
            TModel model = Repository.Find(id);

            if (model == null)
            {
                return NotFound();
            }

            TUpdate modelToPatch = Mapper.Map<TUpdate>(model);
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