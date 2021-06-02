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
	[Authorize(Roles = "Administrador")]
	[Route("Administrador/[controller]/[action]")]
    public class TrabajosController : Controller
    {
        private readonly honcizekContext _context;

        public TrabajosController(honcizekContext context)
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
            ViewData["general"] = true;
            var honcizekContext = _context.Trabajos.Where(t => t.ProyectoId == id).Include(t => t.Proyecto).Include(t => t.Agente).OrderByDescending(t => t.AgenteId);
            ViewData["proyecto_id"] = id;
            return View("Views/Administrador/Trabajos/Index.cshtml",await honcizekContext.ToListAsync());
        }

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
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName");
            return View("Views/Administrador/Trabajos/Create.cshtml");
        }

        // POST: Trabajos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
            
            ViewData["proyecto_id"] = trabajos.ProyectoId;
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName",trabajos.AgenteId);
            return View("Views/Administrador/Trabajos/Edit.cshtml",trabajos);
        }

        // POST: Trabajos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Trabajos/Delete/5
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

        // POST: Trabajos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trabajos = await _context.Trabajos.FindAsync(id);
            _context.Trabajos.Remove(trabajos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { id = trabajos.ProyectoId });
        }

        private bool TrabajosExists(int id)
        {
            return _context.Trabajos.Any(e => e.Id == id);
        }
    }
}
