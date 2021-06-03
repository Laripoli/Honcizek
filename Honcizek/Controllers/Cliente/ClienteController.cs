using Honcizek.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace Honcizek.Controllers.Cliente
{
    /// <summary>
    /// Gestiona el escritorio del cliente
    /// </summary>
    [Authorize(Roles = "Cliente")]
    public class ClienteController : Controller
    {
        private readonly honcizekContext _context;

        public ClienteController(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Redirecciona al escritorio del cliente
        /// </summary>
        /// <returns></returns>
        [Route("Escritorio")]
        public IActionResult Escritorio()
        {
            DateTime hoy = DateTime.Now;
            var fecha = hoy.ToString("yyyy-MM-dd");
            var usuario_id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);

            var proyectos = _context.Proyectos.Where(p => p.ClienteId == usuario_id).Count();
            var tickets = _context.Tickets.Where(t =>t.ClienteId == usuario_id && (t.Estado != "Finalizado" && t.Estado != "Cancelado")).Count();
            var suscripciones = _context.Suscripciones.Where(s => s.ClienteId == usuario_id && s.FechaHasta > hoy).Count();

            ViewData["nombre"] = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;
            ViewData["proyectos"] = proyectos;
            ViewData["tickets"] = tickets;
            ViewData["suscripciones"] = suscripciones;

            return View("Views/Cliente/Escritorio.cshtml");
        }
    }
}
