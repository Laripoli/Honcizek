using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Honcizek.Controllers.Administrador
{
    [Authorize(Roles = "Administrador")]
    public class AdministradorController : Controller
    {
        public IActionResult Escritorio()
        {
            ViewData["Layout"] = "_Admin";
            return View();
        }
    }
}
