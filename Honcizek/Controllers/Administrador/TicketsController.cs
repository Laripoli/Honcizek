using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Honcizek.DAL.Models;
using Newtonsoft.Json;
using System.Security.Claims;

namespace Honcizek.Controllers_Administrador
{
	[Authorize(Roles = "Administrador")]
	[Route("Administrador/[controller]/[action]")]
    public class TicketsController : Controller
    {
        private readonly honcizekContext _context;

        public TicketsController(honcizekContext context)
        {
            _context = context;
        }

        // GET: Tickets
        public async Task<IActionResult> Index(String nombre, String cliente)
        {
            
            ViewData["error"] = false;
            ViewData["general"] = true;

            ViewData["nombreFilter"] = nombre;
            ViewData["clienteFilter"] = cliente;
            var query = "SELECT T.* FROM tickets T " +
                "LEFT JOIN usuarios U ON U.id = T.agente_id " +
                "LEFT JOIN clientes C ON C.id = T.cliente_id " +
                "LEFT JOIN suscripciones S ON S.id = T.suscripcion_id";

            if (!String.IsNullOrEmpty(nombre) || !String.IsNullOrEmpty(cliente))
            {
                query += " Where ";
                if (!String.IsNullOrEmpty(nombre))
                {
                    query += " T.nombre like '%" + nombre + "%'";
                }
                if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(cliente))
                {
                    query += " And (CONCAT(C.nombre,' ',C.apellidos) LIKE '%" + cliente + "%'" +
                         " OR C.razon_social like '%" + cliente + "%')";
                }
                if (String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(cliente))
                {
                    query += " CONCAT(C.nombre,' ',C.apellidos) LIKE '%" + cliente + "%'" +
                         " OR C.razon_social like '%" + cliente + "%'";
                }
            }
            var honcizekContext = _context.Tickets.FromSqlRaw(query).Include(t => t.Agente).Include(t => t.Cliente).Include(t => t.Suscripcion);
            return View("Views/Administrador/Tickets/Index.cshtml",await honcizekContext.ToListAsync());
        }

        public async Task<IActionResult> IndexUsuario(String nombre, String cliente)
        {

            ViewData["error"] = false;
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            var usuario = await _context.Usuarios.FindAsync(Id);
            if (usuario == null)
            {
                ViewData["error"] = true;
            }
            ViewData["general"] = false;

            var query = "SELECT T.* FROM tickets T " +
                "LEFT JOIN usuarios U ON U.id = T.agente_id " +
                "LEFT JOIN clientes C ON C.id = T.cliente_id " +
                "LEFT JOIN suscripciones S ON S.id = T.suscripcion_id " +
                "WHERE T.agente_id = {0}";


            /*if (!String.IsNullOrEmpty(nombre))
            {
                honcizekContext = _context.Tickets.Where(t => t.AgenteId == Id && t.Nombre.Contains(nombre))
                    .Include(t => t.Cliente).Where(t => t.Cliente.FullName == "Álvaro").Include(t => t.Suscripcion);
            }*/
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
            return View("Views/Administrador/Tickets/Index.cshtml", await honcizekContext.ToListAsync());
        }

        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
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

            return View("Views/Administrador/Tickets/Details.cshtml",tickets);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName");
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "FullName");
            ViewData["SuscripcionId"] = new SelectList(_context.Suscripciones, "Id", "Nombre");
            ViewData["Estado"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Pendiente", Value = "Pendiente"},
                    new SelectListItem {Text = "En proceso", Value = "En proceso"},
                    new SelectListItem {Text = "Finalizado", Value = "Finalizado"},
                    new SelectListItem {Text = "Cancelado", Value = "Cancelado"}
                };
            DateTime hoy = DateTime.Now;
            ViewData["hoy"] = hoy.ToString("yyyy-MM-dd");
            ViewData["hora"] = hoy.ToString("HH:mm");
            return View("Views/Administrador/Tickets/Create.cshtml");
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SuscripcionId,ClienteId,AgenteId,Nombre,Descripcion,FechaRegistro,HoraRegistro,Estado,FechaFinalizacion,HoraFinalizacion")] Tickets tickets)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tickets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
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
            DateTime hoy = DateTime.Today;
            ViewData["hoy"] = hoy.ToString("yyyy-MM-dd");
            ViewData["hora"] = hoy.ToString("H:m");
            return View("Views/Administrador/Tickets/Create.cshtml",tickets);
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
            return View("Views/Administrador/Tickets/Edit.cshtml",tickets);
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
                return RedirectToAction(nameof(Index));
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
            return View("Views/Administrador/Tickets/Edit.cshtml",tickets);
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

            return View("Views/Administrador/Tickets/Delete.cshtml",tickets);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tickets = await _context.Tickets.FindAsync(id);
            _context.Tickets.Remove(tickets);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketsExists(int id)
        {
            return _context.Tickets.Any(e => e.Id == id);
        }
        [HttpPost]
        public async Task<IEnumerable<int>> cargar_hidden(int suscripcion_id)
        {
            List<int> list = new List<int>();
            var suscripcion = await _context.Suscripciones.FirstOrDefaultAsync(s => s.Id == suscripcion_id);
            list.Add(suscripcion.ClienteId);
            list.Add(suscripcion.AgenteId);
            IEnumerable<int> ids = list;
            return ids;
        }
    }
}
