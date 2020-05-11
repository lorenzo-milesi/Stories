using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Stories.Dtos;
using Stories.Meta;

namespace Stories.Controllers
{
    public interface IController
    {
        public ActionResult<IndexDto> Index(int page = 1, int limit = 100);
        public ActionResult<ShowDto> Show(int id);
        public ActionResult Delete(int id);
    }
}