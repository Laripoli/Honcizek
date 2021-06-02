using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Honcizek.DAL.Models;

namespace Honcizek.Controllers.Programador
{
	[Authorize(Roles = "Programador")]
	[Route("Programador/[controller]/[action]")]
    public class PartesPController : Controller
    {
        private readonly honcizekContext _context;

        public PartesPController(honcizekContext context)
        {
            _context = context;
        }

        // GET: Partes
        public async Task<IActionResult> Index()
        {
            var honcizekContext = _context.PartesDeTrabajo.Include(p => p.Agente).Include(p => p.Ticket);
            return View("Views/Programador/Partes/Index.cshtml",await honcizekContext.ToListAsync());
        }

        // GET: Partes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partesDeTrabajo = await _context.PartesDeTrabajo
                .Include(p => p.Agente)
                .Include(p => p.Ticket)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partesDeTrabajo == null)
            {
                return NotFound();
            }

            return View("Views/Programador/Partes/Details.cshtml",partesDeTrabajo);
        }

        // GET: Partes/Create
        public IActionResult Create()
        {
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Clave");
            ViewData["TicketId"] = new SelectList(_context.Tickets, "Id", "Descripcion");
            return View("Views/Programador/Partes/Create.cshtml");
        }

        // POST: Partes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TicketId,AgenteId,Nombre,Fecha,Hora,Descripcion,Horas,Minutos")] PartesDeTrabajo partesDeTrabajo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(partesDeTrabajo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Clave", partesDeTrabajo.AgenteId);
            ViewData["TicketId"] = new SelectList(_context.Tickets, "Id", "Descripcion", partesDeTrabajo.TicketId);
            return View("Views/Programador/Partes/Create.cshtml",partesDeTrabajo);
        }

        // GET: Partes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partesDeTrabajo = await _context.PartesDeTrabajo.FindAsync(id);
            if (partesDeTrabajo == null)
            {
                return NotFound();
            }
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Clave", partesDeTrabajo.AgenteId);
            ViewData["TicketId"] = new SelectList(_context.Tickets, "Id", "Descripcion", partesDeTrabajo.TicketId);
            return View("Views/Programador/Partes/Edit.cshtml",partesDeTrabajo);
        }

        // POST: Partes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TicketId,AgenteId,Nombre,Fecha,Hora,Descripcion,Horas,Minutos")] PartesDeTrabajo partesDeTrabajo)
        {
            if (id != partesDeTrabajo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(partesDeTrabajo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartesDeTrabajoExists(partesDeTrabajo.Id))
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
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Clave", partesDeTrabajo.AgenteId);
            ViewData["TicketId"] = new SelectList(_context.Tickets, "Id", "Descripcion", partesDeTrabajo.TicketId);
            return View("Views/Programador/Partes/Edit.cshtml",partesDeTrabajo);
        }

        // GET: Partes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partesDeTrabajo = await _context.PartesDeTrabajo
                .Include(p => p.Agente)
                .Include(p => p.Ticket)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partesDeTrabajo == null)
            {
                return NotFound();
            }

            return View("Views/Programador/Partes/Delete.cshtml",partesDeTrabajo);
        }

        // POST: Partes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partesDeTrabajo = await _context.PartesDeTrabajo.FindAsync(id);
            _context.PartesDeTrabajo.Remove(partesDeTrabajo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartesDeTrabajoExists(int id)
        {
            return _context.PartesDeTrabajo.Any(e => e.Id == id);
        }
    }
}
