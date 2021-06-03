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

namespace Honcizek.Controllers.Administrador
{
    /// <summary>
    /// Controlador de partes de trabajo de un ticket
    /// </summary>
	[Authorize(Roles = "Administrador")]
	[Route("Administrador/[controller]/[action]")]
    public class PartesController : Controller
    {
        private readonly honcizekContext _context;

        public PartesController(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Listado de partes de trabajo de un ticket en concreto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(int? id)
        {
            ViewData["finalizado"] = false;
            if (id == null)
            {
                return NotFound();
            }
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            ViewData["aviso"] = false;
            ViewData["error"] = false;
            var tickets = await _context.Tickets.FindAsync(id);
            if (tickets == null)
            {
                ViewData["error"] = true;

            }
            else
            {
                if (tickets.Estado == "Finalizado" || tickets.Estado == "Cancelado") 
                {
                    ViewData["finalizado"] = true;
                }
                if (tickets.AgenteId != Id)
                {
                    ViewData["aviso"] = true;
                }
            }
            ViewData["general"] = true;
            ViewData["TicketId"] = id;

            /*string query = "Select * from partes_de_trabajo where ticket_id= {0}";
            var honcizekContext = _context.PartesDeTrabajo.FromSqlRaw(query, id).Include(p => p.Agente).Include(p => p.Ticket);*/
            var honcizekContext = _context.PartesDeTrabajo.Where(p => p.TicketId == id).Include(p => p.Agente).Include(p => p.Ticket);
            return View("Views/Administrador/Partes/Index.cshtml",await honcizekContext.ToListAsync());
        }


        /// <summary>
        /// Redirecci�n a la vista de crear un parte de trabajo para un ticket en espec�fico
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
            var tickets = await _context.Tickets.FindAsync(id);
            if (tickets == null)
            {
                ViewData["error"] = true;
            }
            
            ViewData["AgenteId"] = tickets.AgenteId;
            ViewData["TicketId"] = id;
            DateTime hoy = DateTime.Now;
            ViewData["hoy"] = hoy.ToString("yyyy-MM-dd");
            ViewData["hora"] = hoy.ToString("HH:mm");
            return View("Views/Administrador/Partes/Create.cshtml");
        }

        /// <summary>
        /// Validaci�n del parte de trabajo creado y en caso de error devuelve a la vista de creaci�n de parte de trabajo
        /// </summary>
        /// <param name="partesDeTrabajo"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TicketId,AgenteId,Nombre,Fecha,Hora,Descripcion,Horas,Minutos")] PartesDeTrabajo partesDeTrabajo)
        {
            if (ModelState.IsValid)
            {
                checkEstadoTicket(partesDeTrabajo.TicketId);
                _context.Add(partesDeTrabajo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { id = partesDeTrabajo.TicketId });
            }
            ViewData["error"] = false;
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName", partesDeTrabajo.AgenteId);
            ViewData["TicketId"] = partesDeTrabajo.TicketId;
            DateTime hoy = DateTime.Now;
            ViewData["hoy"] = hoy.ToString("yyyy-MM-dd");
            ViewData["hora"] = hoy.ToString("HH:mm");
            return View("Views/Administrador/Partes/Create.cshtml",partesDeTrabajo);
        }

        /// <summary>
        /// Redirecci�n a la vista de editar un parte de trabajo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName", partesDeTrabajo.AgenteId);
            ViewData["TicketId"] = partesDeTrabajo.TicketId;
            return View("Views/Administrador/Partes/Edit.cshtml",partesDeTrabajo);
        }

        /// <summary>
        /// Validaci�n del parte de trabajo editado y en caso de error devuelve a la vista de edici�n de parte de trabajo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="partesDeTrabajo"></param>
        /// <returns></returns>
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
                return RedirectToAction(nameof(Index), new { id = partesDeTrabajo.TicketId });
            }
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName", partesDeTrabajo.AgenteId);
            ViewData["TicketId"] = partesDeTrabajo.TicketId;
            return View("Views/Administrador/Partes/Edit.cshtml",partesDeTrabajo);
        }

        /// <summary>
        /// Redirecci�n a la vista de eliminaci�n de parte de trabajo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
            ViewData["TicketId"] = partesDeTrabajo.TicketId;
            return View("Views/Administrador/Partes/Delete.cshtml",partesDeTrabajo);
        }

        /// <summary>
        /// Confirmaci�n de eliminaci�n y redirecciona al listado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partesDeTrabajo = await _context.PartesDeTrabajo.FindAsync(id);
            _context.PartesDeTrabajo.Remove(partesDeTrabajo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { id = partesDeTrabajo.TicketId });
        }
        /// <summary>
        /// Comprueba si el parte de trabajo existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool PartesDeTrabajoExists(int id)
        {
            return _context.PartesDeTrabajo.Any(e => e.Id == id);
        }
        /// <summary>
        /// Comprueba si el ticket sigue pendiente, si est� pendiente pasa a estar en proceso
        /// </summary>
        /// <param name="id"></param>
        private async void checkEstadoTicket(int id)
        {
            var tickets = await _context.Tickets.FindAsync(id);
            if(tickets.Estado == "Pendiente")
            {
                tickets.Estado = "En proceso";
                _context.Update(tickets);
            }
        }
    }
}
