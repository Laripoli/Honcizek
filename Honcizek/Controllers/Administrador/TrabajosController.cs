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

namespace Honcizek.Controllers_Administrador
{
    /// <summary>
    /// Controlador de trabajos
    /// </summary>
	[Authorize(Roles = "Administrador")]
	[Route("Administrador/[controller]/[action]")]
    public class TrabajosController : Controller
    {
        private readonly honcizekContext _context;

        public TrabajosController(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Redirecciona al listado de trabajos de un proyecto
        /// Gestiona tanto el listado como el listado filtrado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["error"] = false;
            var proyectos = await _context.Proyectos.FindAsync(id);
            if (proyectos == null)
            {
                ViewData["error"] = true;
            }
            ViewData["general"] = true;
            var honcizekContext = _context.Trabajos.Where(t => t.ProyectoId == id).Include(t => t.Proyecto).Include(t => t.Agente).OrderByDescending(t => t.AgenteId);
            ViewData["proyecto_id"] = id;
            return View("Views/Administrador/Trabajos/Index.cshtml",await honcizekContext.ToListAsync());
        }

        /// <summary>
        /// Redirecciona al listado de trabajos de un proyecto realizados por el usuario
        /// Gestiona tanto el listado como el listado filtrado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> IndexUsuario(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["error"] = false;
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);

            var proyectos = await _context.Proyectos.FindAsync(id);
            if (proyectos == null)
            {
                ViewData["error"] = true;
            }

            ViewData["general"] = false;
            var honcizekContext = _context.Trabajos.Where(t => t.ProyectoId == id && t.AgenteId == Id)
                .Include(t => t.Proyecto).Include(t => t.Agente).OrderByDescending(t => t.AgenteId);
            ViewData["proyecto_id"] = id;
            return View("Views/Administrador/Trabajos/Index.cshtml", await honcizekContext.ToListAsync());
        }

        /// <summary>
        /// Redirecciona a la creación de un trabajo de un proyecto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Create(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["error"] = false;
            var proyectos = await _context.Proyectos.FindAsync(id);
            if (proyectos == null)
            {
                ViewData["error"] = true;
            }
            ViewData["proyecto_id"] = id;
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName");
            return View("Views/Administrador/Trabajos/Create.cshtml");
        }

        /// <summary>
        /// Valida y guarda un trabajo y redirecciona al listado, en caso de error vuelve a la creación
        /// </summary>
        /// <param name="trabajos"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProyectoId,AgenteId,Nombre,Descripcion")] Trabajos trabajos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trabajos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { id = trabajos.ProyectoId });
            }
            ViewData["error"] = false;
            ViewData["proyecto_id"] = trabajos.ProyectoId;
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName",trabajos.AgenteId);
            return View("Views/Administrador/Trabajos/Create.cshtml",trabajos);
        }

        /// <summary>
        /// Redirecciona a la edición del trabajo de un proyecto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trabajos = await _context.Trabajos.FindAsync(id);
            if (trabajos == null)
            {
                return NotFound();
            }
            
            ViewData["proyecto_id"] = trabajos.ProyectoId;
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName",trabajos.AgenteId);
            return View("Views/Administrador/Trabajos/Edit.cshtml",trabajos);
        }

        /// <summary>
        /// Valida y actualiza un trabajo y redirecciona al listado, en caso de error vuelve a la edición
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trabajos"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProyectoId,AgenteId,Nombre,Descripcion")] Trabajos trabajos)
        {
            if (id != trabajos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trabajos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrabajosExists(trabajos.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = trabajos.ProyectoId });
            }
            ViewData["proyecto_id"] = trabajos.ProyectoId;
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName",trabajos.AgenteId);
            return View("Views/Administrador/Trabajos/Edit.cshtml",trabajos);
        }

        /// <summary>
        /// Redirecciona a la eliminación de un trabajo de proyecto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var trabajos = await _context.Trabajos
                .Include(t => t.Proyecto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trabajos == null)
            {
                return NotFound();
            }

            return View("Views/Administrador/Trabajos/Delete.cshtml",trabajos);
        }

        /// <summary>
        /// Elimina el trabajo y redirecciona al listado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trabajos = await _context.Trabajos.FindAsync(id);
            _context.Trabajos.Remove(trabajos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { id = trabajos.ProyectoId });
        }

        /// <summary>
        /// Comprueba si el trabajo existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool TrabajosExists(int id)
        {
            return _context.Trabajos.Any(e => e.Id == id);
        }
    }
}
