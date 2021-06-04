using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Honcizek.DAL.Models;
using System.Security.Claims;

namespace Honcizek.Controllers.Cliente
{
    /// <summary>
    /// Controlador de los proyectos del cliente
    /// </summary>
	[Authorize(Roles = "Cliente")]
	[Route("/Proyectos/[action]")]
    public class ProyectosCController : Controller
    {
        private readonly honcizekContext _context;

        public ProyectosCController(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Redirecciona al listado de proyectos del cliente
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Listado()
        {
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            var honcizekContext = _context.Proyectos.Where(p => p.ClienteId == Id).Include(p => p.Cliente);
            return View("Views/Cliente/Proyectos/Index.cshtml",await honcizekContext.ToListAsync());
        }

        /// <summary>
        /// Redirecciona a la vista de información de un proyecto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Ver(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proyectos = await _context.Proyectos.FindAsync(id);
            if (proyectos == null)
            {
                return NotFound();
            }
            ViewData["Tipo"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Cliente", Value = "Cliente",Selected = (proyectos.Tipo=="Cliente")?true:false},
                    new SelectListItem {Text = "Interno", Value = "Interno",Selected = (proyectos.Tipo=="Interno")?true:false}
                };
            ViewData["Estado"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Pendiente", Value = "Pendiente",Selected = (proyectos.Estado=="Pendiente")?true:false},
                    new SelectListItem {Text = "En curso", Value = "En curso",Selected = (proyectos.Estado=="En curso")?true:false},
                    new SelectListItem {Text = "Finalizado", Value = "Finalizado",Selected = (proyectos.Estado=="Finalizado")?true:false}
                };
            proyectos.Fase = proyectos.Fase == "Diseño" ? "Diseno" : proyectos.Fase;
            return View("Views/Cliente/Proyectos/Edit.cshtml", proyectos);
        }
        /// <summary>
        /// Comprueba si el proyecto existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool ProyectosExists(int id)
        {
            return _context.Proyectos.Any(e => e.Id == id);
        }
    }
}
