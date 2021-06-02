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
    public class TicketsPController : Controller
    {
        private readonly honcizekContext _context;

        public TicketsPController(honcizekContext context)
        {
            _context = context;
        }

        // GET: Tickets
        public async Task<IActionResult> Index(String nombre, String cliente)
        {
            var query = "SELECT T.* FROM tickets T " +
                "LEFT JOIN usuarios U ON U.id = T.agente_id " +
                "LEFT JOIN clientes C ON C.id = T.cliente_id " +
                "LEFT JOIN suscripciones S ON S.id = T.suscripcion_id " +
                "WHERE T.agente_id = {0}";

            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            var usuario = await _context.Usuarios.FindAsync(Id);

            ViewData["error"] = false;
            ViewData["general"] = true;

            if (usuario == null)
            {
                ViewData["error"] = true;
            }
            if (!String.IsNullOrEmpty(nombre))
            {
                query += " AND T.nombre like '%" + nombre + "%'";
            }
            if (!String.IsNullOrEmpty(cliente))
            {
                query += " AND (CONCAT(C.nombre,' ',C.apellidos) LIKE '%" + cliente + "%'" +
                     " OR C.razon_social like '%" + cliente + "%')";
            }
            ViewData["nombreFilter"] = nombre;
            ViewData["clienteFilter"] = cliente;
            var honcizekContext = _context.Tickets.FromSqlRaw(query,Id).Include(t => t.Agente).Include(t => t.Cliente).Include(t => t.Suscripcion);
            return View("Views/Programador/Tickets/Index.cshtml",await honcizekContext.ToListAsync());
        }

        public async Task<IActionResult> IndexUsuario(String nombre, String cliente)
        {
            var query = "SELECT T.* FROM tickets T " +
                "LEFT JOIN usuarios U ON U.id = T.agente_id " +
                "LEFT JOIN clientes C ON C.id = T.cliente_id " +
                "LEFT JOIN suscripciones S ON S.id = T.suscripcion_id " +
                "WHERE T.agente_id = {0} AND T.Estado IN('En proceso','Pendiente')";

            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            var usuario = await _context.Usuarios.FindAsync(Id);

            ViewData["error"] = false;
            ViewData["general"] = false;

            if (usuario == null)
            {
                ViewData["error"] = true;
            }
            if (!String.IsNullOrEmpty(nombre))
            {
                query += " AND T.nombre like '%" + nombre + "%'";
            }
            if (!String.IsNullOrEmpty(cliente))
            {
                query += " AND (CONCAT(C.nombre,' ',C.apellidos) LIKE '%" + cliente + "%'" +
                     " OR C.razon_social like '%" + cliente + "%')";
            }
            ViewData["nombreFilter"] = nombre;
            ViewData["clienteFilter"] = cliente;
            var honcizekContext = _context.Tickets.FromSqlRaw(query, Id).Include(t => t.Agente).Include(t => t.Cliente).Include(t => t.Suscripcion);
            return View("Views/Programador/Tickets/Index.cshtml", await honcizekContext.ToListAsync());
        }

        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName", tickets.AgenteId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "FullName", tickets.ClienteId);
            ViewData["SuscripcionId"] = new SelectList(_context.Suscripciones, "Id", "Nombre", tickets.SuscripcionId);
            ViewData["Estado"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Pendiente", Value = "Pendiente",Selected = (tickets.Estado=="Pendiente")?true:false},
                    new SelectListItem {Text = "En proceso", Value = "En proceso",Selected = (tickets.Estado=="En proceso")?true:false},
                    new SelectListItem {Text = "Finalizado", Value = "Finalizado",Selected = (tickets.Estado=="Finalizado")?true:false},
                    new SelectListItem {Text = "Cancelado", Value = "Cancelado",Selected = (tickets.Estado=="Cancelado")?true:false}
                };
            return View("Views/Programador/Tickets/Edit.cshtml",tickets);
        }

        private bool TicketsExists(int id)
        {
            return _context.Tickets.Any(e => e.Id == id);
        }
    }
}
