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

namespace Honcizek.Controllers_Programador
{
	[Authorize(Roles = "Programador")]
	[Route("Programador/[controller]/[action]")]
    public class TrabajosPController : Controller
    {
        private readonly honcizekContext _context;

        public TrabajosPController(honcizekContext context)
        {
            _context = context;
        }

        // GET: Trabajos
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
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            ViewData["usuario_id"] = Id;
            ViewData["general"] = true;
            var honcizekContext = _context.Trabajos.Where(t => t.ProyectoId == id).Include(t => t.Proyecto).Include(t => t.Agente).OrderByDescending(t => t.AgenteId);
            ViewData["proyecto_id"] = id;
            return View("Views/Programador/Trabajos/Index.cshtml", await honcizekContext.ToListAsync());
            
        }

        public async Task<IActionResult> IndexUsuario(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["error"] = false;
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            ViewData["usuario_id"] = Id;
            var proyectos = await _context.Proyectos.FindAsync(id);
            if (proyectos == null)
            {
                ViewData["error"] = true;
            }

            ViewData["general"] = false;
            var honcizekContext = _context.Trabajos.Where(t => t.ProyectoId == id && t.AgenteId == Id)
                .Include(t => t.Proyecto).Include(t => t.Agente).OrderByDescending(t => t.AgenteId);
            ViewData["proyecto_id"] = id;
            return View("Views/Programador/Trabajos/Index.cshtml", await honcizekContext.ToListAsync());
        }

        // GET: Trabajos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trabajos = await _context.Trabajos
                .Include(t => t.Agente)
                .Include(t => t.Proyecto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trabajos == null)
            {
                return NotFound();
            }

            return View("Views/Programador/Trabajos/Details.cshtml",trabajos);
        }

        // GET: Trabajos/Create
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

            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            ViewData["usuario_id"] = Id;
            return View("Views/Programador/Trabajos/Create.cshtml");
        }

        // POST: Trabajos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProyectoId,Nombre,AgenteId,Descripcion")] Trabajos trabajos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trabajos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexUsuario), new { id = trabajos.ProyectoId });
            }
            
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);

            ViewData["error"] = false;
            ViewData["proyecto_id"] = trabajos.ProyectoId;
            ViewData["usuario_id"] = Id;
            return View("Views/Programador/Trabajos/Create.cshtml",trabajos);
        }

        // GET: Trabajos/Edit/5
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
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);

            ViewData["readonly"] = trabajos.AgenteId != Id;
            ViewData["usuario_id"] = Id;
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName", trabajos.AgenteId);
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Nombre", trabajos.ProyectoId);
            return View("Views/Programador/Trabajos/Edit.cshtml",trabajos);
        }

        // POST: Trabajos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProyectoId,Nombre,AgenteId,Descripcion")] Trabajos trabajos)
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
                return RedirectToAction(nameof(IndexUsuario), new { id = trabajos.ProyectoId });
            }
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            ViewData["usuario_id"] = Id;
            ViewData["readonly"] = false;
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName", trabajos.AgenteId);
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Nombre", trabajos.ProyectoId);
            return View("Views/Programador/Trabajos/Edit.cshtml",trabajos);
        }

        // GET: Trabajos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trabajos = await _context.Trabajos
                .Include(t => t.Agente)
                .Include(t => t.Proyecto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trabajos == null)
            {
                return NotFound();
            }

            return View("Views/Programador/Trabajos/Delete.cshtml",trabajos);
        }

        // POST: Trabajos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trabajos = await _context.Trabajos.FindAsync(id);
            _context.Trabajos.Remove(trabajos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexUsuario), new { id = trabajos.ProyectoId });
        }

        private bool TrabajosExists(int id)
        {
            return _context.Trabajos.Any(e => e.Id == id);
        }
    }
}
