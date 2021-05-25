using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Honcizek.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/handle/404")]
        public IActionResult Error404()
        {
            ViewData["layout"] = "";
            return View("Error404");
        }
    }
}
