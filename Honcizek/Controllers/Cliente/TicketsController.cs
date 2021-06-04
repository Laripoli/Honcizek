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
    /// <summary>
    /// Controlador de tickets del cliente
    /// </summary>
	[Authorize(Roles = "Cliente")]
	[Route("Tickets/[action]")]
    public class TicketsCController : Controller
    {
        private readonly honcizekContext _context;

        public TicketsCController(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Redirecciona al listado de tickets pendientes de la suscripcion indicada
        /// Además comprueba que el cliente sea el dueño de la suscripcion
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Redirecciona al listado de todos los tickets de la suscripcion indicada
        /// Además comprueba que la suscripción séa del cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Redirecciona a la creación de un ticket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Valida y guarda el nuevo ticket, si es correcto redirecciona al listado de tickets, en caso de error
        /// vuelve a la creación
        /// </summary>
        /// <param name="tickets"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Redirecciona a la ficha de un ticket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Comprueba si el ticket existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool TicketsExists(int id)
        {
            return _context.Tickets.Any(e => e.Id == id);
        }
    }
}
