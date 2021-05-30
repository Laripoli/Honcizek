﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Honcizek.Controllers.Administrador
{
    [Authorize(Roles = "Administrador")]
    public class ProgramadorController : Controller
    {
        [Route("Administrador/Escritorio")]
        public IActionResult Escritorio()
        {
            return View("Views/Administrador/Escritorio.cshtml");
        }
    }
}
