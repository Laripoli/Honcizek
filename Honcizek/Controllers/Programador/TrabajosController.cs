using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Honcizek.DAL.Models;

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

            var honcizekContext = _context.Trabajos.Where(t => t.ProyectoId == id).Include(t => t.Proyecto).Include(t => t.Agente).OrderByDescending(t => t.AgenteId == id);
            return View("Views/Programador/Trabajos/Index.cshtml",await honcizekContext.ToListAsync());
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
        public IActionResult Create()
        {
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Clave");
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Estado");
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Clave", trabajos.AgenteId);
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Estado", trabajos.ProyectoId);
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
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Clave", trabajos.AgenteId);
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Estado", trabajos.ProyectoId);
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Clave", trabajos.AgenteId);
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Estado", trabajos.ProyectoId);
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
            return RedirectToAction(nameof(Index));
        }

        private bool TrabajosExists(int id)
        {
            return _context.Trabajos.Any(e => e.Id == id);
        }
    }
}
