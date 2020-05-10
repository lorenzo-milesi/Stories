using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Stories.Dtos;

namespace Stories.Controllers
{
    public interface IController
    {
        public ActionResult<IEnumerable<IndexDto>> Index(int page = 1, int limit = 100);
    }
}