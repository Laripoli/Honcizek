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
	[Authorize(Roles = "Cliente")]
	[Route("Tickets/[action]")]
    public class TicketsCController : Controller
    {
        private readonly honcizekContext _context;

        public TicketsCController(honcizekContext context)
        {
            _context = context;
        }

        // GET: Tickets
        public async Task<IActionResult> Listado(int? id)
        {
            var suscripciones = await _context.Suscripciones.FindAsync(id);
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            if(suscripciones == null)
            {
                return NotFound();
            }
            if(suscripciones.ClienteId != Id)
            {
                return NotFound();
            }
            ViewData["general"] = false;
            ViewData["suscripcion_id"] = id;
            var query = "Select * from tickets T where suscripcion_id = {0} AND estado in('Pendiente','En proceso')";
            var honcizekContext = _context.Tickets.FromSqlRaw(query, id)
                .Include(t => t.Agente).Include(t => t.Cliente).Include(t => t.Suscripcion)
                .OrderByDescending(t => t.FechaRegistro).ThenByDescending(t => t.HoraRegistro);
            return View("Views/Cliente/Tickets/Index.cshtml",await honcizekContext.ToListAsync());
        }

        public async Task<IActionResult> ListadoCompleto(int? id)
        {
            var suscripciones = await _context.Suscripciones.FindAsync(id);
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            if (suscripciones == null)
            {
                return NotFound();
            }
            if (suscripciones.ClienteId != Id)
            {
                return NotFound();
            }
            ViewData["suscripcion_id"] = id;
            ViewData["general"] = true;
            var query = "Select * from tickets T where suscripcion_id = {0}";
            var honcizekContext = _context.Tickets.FromSqlRaw(query, id)
                .Include(t => t.Agente).Include(t => t.Cliente).Include(t => t.Suscripcion)
                .OrderByDescending(t => t.FechaRegistro).ThenByDescending(t => t.HoraRegistro);
            return View("Views/Cliente/Tickets/Index.cshtml", await honcizekContext.ToListAsync());
        }

        // GET: Tickets/Create
        public async Task<IActionResult> Crear(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            var suscripciones = await _context.Suscripciones.FindAsync(id);
            if(suscripciones == null || suscripciones.ClienteId != Id)
            {
                return NotFound();
            }
            ViewData["AgenteId"] = suscripciones.AgenteId;
            ViewData["ClienteId"] = Id;
            ViewData["SuscripcionId"] = id;
            DateTime hoy = DateTime.Now;
            ViewData["hoy"] = hoy.ToString("yyyy-MM-dd");
            ViewData["hora"] = hoy.ToString("HH:mm");
            return View("Views/Cliente/Tickets/Create.cshtml");
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([Bind("Id,SuscripcionId,ClienteId,AgenteId,Nombre,Descripcion,FechaRegistro,HoraRegistro,Estado,FechaFinalizacion,HoraFinalizacion")] Tickets tickets)
        {
            tickets.Estado = "Pendiente";
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            if(tickets.ClienteId == Id)
            {

                if (ModelState.IsValid)
                {
                    _context.Add(tickets);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Listado), new { id = tickets.SuscripcionId });
                }
            }
            else
            {
                return NotFound();
            }
            ViewData["AgenteId"] = tickets.AgenteId;
            ViewData["ClienteId"] = tickets.ClienteId;
            ViewData["SuscripcionId"] = tickets.SuscripcionId;
            return View("Views/Cliente/Tickets/Create.cshtml",tickets);
        }

        // GET: Tickets/Edit/5
        public async Task<IActionResult> Ver(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tickets = await _context.Tickets.FindAsync(id);
            if (tickets == null)
            {
                return NotFound();
            }
            ViewData["AgenteId"] = tickets.AgenteId;
            ViewData["ClienteId"] = tickets.ClienteId;
            ViewData["SuscripcionId"] = tickets.SuscripcionId;
            ViewData["Estado"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Pendiente", Value = "Pendiente",Selected = (tickets.Estado=="Pendiente")?true:false},
                    new SelectListItem {Text = "En proceso", Value = "En proceso",Selected = (tickets.Estado=="En proceso")?true:false},
                    new SelectListItem {Text = "Finalizado", Value = "Finalizado",Selected = (tickets.Estado=="Finalizado")?true:false},
                    new SelectListItem {Text = "Cancelado", Value = "Cancelado",Selected = (tickets.Estado=="Cancelado")?true:false}
                };
            return View("Views/Cliente/Tickets/Edit.cshtml",tickets);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SuscripcionId,ClienteId,AgenteId,Nombre,Descripcion,FechaRegistro,HoraRegistro,Estado,FechaFinalizacion,HoraFinalizacion")] Tickets tickets)
        {
            if (id != tickets.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tickets);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketsExists(tickets.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Listado), new { id = tickets.SuscripcionId });
            }
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Clave", tickets.AgenteId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Clave", tickets.ClienteId);
            ViewData["SuscripcionId"] = new SelectList(_context.Suscripciones, "Id", "Nombre", tickets.SuscripcionId);
            return View("Views/Cliente/Tickets/Edit.cshtml",tickets);
        }

        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tickets = await _context.Tickets
                .Include(t => t.Agente)
                .Include(t => t.Cliente)
                .Include(t => t.Suscripcion)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tickets == null)
            {
                return NotFound();
            }

            return View("Views/Cliente/Tickets/Delete.cshtml",tickets);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tickets = await _context.Tickets.FindAsync(id);
            _context.Tickets.Remove(tickets);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Listado), new { id = tickets.SuscripcionId });
        }

        private bool TicketsExists(int id)
        {
            return _context.Tickets.Any(e => e.Id == id);
        }
    }
}
