using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Honcizek.DAL.Models;

namespace Honcizek.Controllers_Administrador
{
	[Authorize(Roles = "Administrador")]
	[Route("Administrador/[controller]/[action]")]
    public class ParticipantesController : Controller
    {
        private readonly honcizekContext _context;

        public ParticipantesController(honcizekContext context)
        {
            _context = context;
        }

        // GET: Participantes
        public async Task<IActionResult> Index()
        {
            var honcizekContext = _context.ProyectosParticipantes.Include(p => p.Proyecto).Include(p => p.Usuario);
            return View("Views/Administrador/Participantes/Index.cshtml",await honcizekContext.ToListAsync());
        }

        // GET: Participantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proyectosParticipantes = await _context.ProyectosParticipantes
                .Include(p => p.Proyecto)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proyectosParticipantes == null)
            {
                return NotFound();
            }

            return View("Views/Administrador/Participantes/Details.cshtml",proyectosParticipantes);
        }

        // GET: Participantes/Create
        public IActionResult Create()
        {
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Estado");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Id");
            return View("Views/Administrador/Participantes/Create.cshtml");
        }

        // POST: Participantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProyectoId,UsuarioId")] ProyectosParticipantes proyectosParticipantes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proyectosParticipantes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Estado", proyectosParticipantes.ProyectoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Id", proyectosParticipantes.UsuarioId);
            return View("Views/Administrador/Participantes/Create.cshtml",proyectosParticipantes);
        }

        // GET: Participantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proyectosParticipantes = await _context.ProyectosParticipantes.FindAsync(id);
            if (proyectosParticipantes == null)
            {
                return NotFound();
            }
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Estado", proyectosParticipantes.ProyectoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Id", proyectosParticipantes.UsuarioId);
            return View("Views/Administrador/Participantes/Edit.cshtml",proyectosParticipantes);
        }

        // POST: Participantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProyectoId,UsuarioId")] ProyectosParticipantes proyectosParticipantes)
        {
            if (id != proyectosParticipantes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proyectosParticipantes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProyectosParticipantesExists(proyectosParticipantes.Id))
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
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Estado", proyectosParticipantes.ProyectoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Id", proyectosParticipantes.UsuarioId);
            return View("Views/Administrador/Participantes/Edit.cshtml",proyectosParticipantes);
        }

        // GET: Participantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proyectosParticipantes = await _context.ProyectosParticipantes
                .Include(p => p.Proyecto)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proyectosParticipantes == null)
            {
                return NotFound();
            }

            return View("Views/Administrador/Participantes/Delete.cshtml",proyectosParticipantes);
        }

        // POST: Participantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proyectosParticipantes = await _context.ProyectosParticipantes.FindAsync(id);
            _context.ProyectosParticipantes.Remove(proyectosParticipantes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProyectosParticipantesExists(int id)
        {
            return _context.ProyectosParticipantes.Any(e => e.Id == id);
        }
    }
}
