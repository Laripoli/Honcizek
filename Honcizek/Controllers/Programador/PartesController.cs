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
        public async Task<IActionResult> Index(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            ViewData["error"] = false;
            var tickets = await _context.Tickets.FindAsync(id);
            if (tickets == null)
            {
                ViewData["error"] = true;
            }
            ViewData["general"] = true;
            ViewData["TicketId"] = id;
            /*string query = "Select * from partes_de_trabajo where ticket_id= {0}";
            var honcizekContext = _context.PartesDeTrabajo.FromSqlRaw(query, id).Include(p => p.Agente).Include(p => p.Ticket);*/
            var honcizekContext = _context.PartesDeTrabajo.Where(p => p.TicketId == id).Include(p => p.Agente).Include(p => p.Ticket);
            return View("Views/Programador/Partes/Index.cshtml", await honcizekContext.ToListAsync());
        }

        // GET: Partes/Create
        public async Task<IActionResult> Create(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["error"] = false;
            var tickets = await _context.Tickets.FindAsync(id);
            if (tickets == null)
            {
                ViewData["error"] = true;
            }

            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);

            ViewData["AgenteId"] = 0;
            ViewData["TicketId"] = id;
            DateTime hoy = DateTime.Now;
            ViewData["hoy"] = hoy.ToString("yyyy-MM-dd");
            ViewData["hora"] = hoy.ToString("H:m");
            return View("Views/Programador/Partes/Create.cshtml");
        }

        // POST: Partes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TicketId,AgenteId,Nombre,Fecha,Hora,Descripcion,Horas,Minutos")] PartesDeTrabajo partesDeTrabajo)
        {
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            partesDeTrabajo.AgenteId = Id;
            if (ModelState.IsValid)
            {
                _context.Add(partesDeTrabajo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { id = partesDeTrabajo.TicketId });
            }
            ViewData["error"] = false;

            ViewData["AgenteId"] = 0;
            ViewData["TicketId"] = partesDeTrabajo.TicketId;
            DateTime hoy = DateTime.Now;
            ViewData["hoy"] = hoy.ToString("yyyy-MM-dd");
            ViewData["hora"] = hoy.ToString("H:m");
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
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);

            ViewData["AgenteId"] = 0;
            ViewData["TicketId"] = partesDeTrabajo.TicketId;
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
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            partesDeTrabajo.AgenteId = Id;

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
                return RedirectToAction(nameof(Index), new { id = partesDeTrabajo.TicketId });
            }

            ViewData["AgenteId"] = 0;
            ViewData["TicketId"] = partesDeTrabajo.TicketId;
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
