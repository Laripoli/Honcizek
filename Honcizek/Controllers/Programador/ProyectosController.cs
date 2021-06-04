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

namespace Honcizek.Controllers.Programador
{
    /// <summary>
    /// Controlador de proyectos de un programador
    /// </summary>
	[Authorize(Roles = "Programador")]
	[Route("Programador/[controller]/[action]")]
    public class ProyectosPController : Controller
    {
        private readonly honcizekContext _context;

        public ProyectosPController(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Redirecciona al listado de proyectos del usuario
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            var usuario = await _context.Usuarios.FindAsync(Id);
            ViewData["error"] = false;
            if (usuario == null)
            {
                ViewData["error"] = true;
            }
            var query = "SELECT P.* FROM proyectos P " +
            "LEFT JOIN proyectos_participantes PP ON PP.proyecto_id = P.id " +
            "LEFT JOIN usuarios U ON U.id = PP.usuario_id " +
            "WHERE U.id = {0}";

            var honcizekContext = _context.Proyectos.FromSqlRaw(query,Id).Include(p => p.Cliente);
            return View("Views/Programador/Proyectos/Index.cshtml",await honcizekContext.ToListAsync());
        }

        /// <summary>
        /// Redirecciona a la ficha de un proyecto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
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
            if (proyectos.Fase == "Dise�o")
            {
                proyectos.Fase = "Diseno";
            }
            ViewData["Estado"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Pendiente", Value = "Pendiente",Selected = (proyectos.Estado=="Pendiente")?true:false},
                    new SelectListItem {Text = "En curso", Value = "En curso",Selected = (proyectos.Estado=="En curso")?true:false},
                    new SelectListItem {Text = "Finalizado", Value = "Finalizado",Selected = (proyectos.Estado=="Finalizado")?true:false}
                };
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "FullName", proyectos.ClienteId);
            return View("Views/Programador/Proyectos/Edit.cshtml",proyectos);
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
