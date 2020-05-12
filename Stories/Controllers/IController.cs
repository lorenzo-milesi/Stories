using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Stories.Dtos;
using Stories.Meta;

namespace Stories.Controllers
{
    public interface IController
    {
        protected ActionResult<IndexDto> Index(int page = 1, int limit = 100);
        protected ActionResult<ShowDto> Show(int id);
        protected ActionResult Delete(int id);
    }
}