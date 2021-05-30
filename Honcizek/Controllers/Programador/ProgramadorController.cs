using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Honcizek.Controllers.Programador
{
    [Authorize(Roles = "Programador")]
    public class ProgramadorController : Controller
    {
        [Route("Programador/Escritorio")]
        public IActionResult Escritorio()
        {
            return View("Views/Programador/Escritorio.cshtml");
        }
    }
}
