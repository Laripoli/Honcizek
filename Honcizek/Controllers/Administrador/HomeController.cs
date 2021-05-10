using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Honcizek.Controllers.Administrador
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private int prueba { get; set; }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            prueba = 0;
            ViewData["click"] = 0;
        }
        public IActionResult Index()
        {
            return View();
        }

        public int suma()
        {
            ViewData["clicks"] = (int)ViewData["clicks"] + 1;
            return prueba++;
        }
    }
}
