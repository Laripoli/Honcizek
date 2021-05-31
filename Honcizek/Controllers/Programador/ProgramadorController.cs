using Honcizek.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Honcizek.Controllers.Programador
{
    [Authorize(Roles = "Programador")]
    public class ProgramadorController : Controller
    {
        private readonly honcizekContext _context;

        public ProgramadorController(honcizekContext context)
        {
            _context = context;
        }
        [Route("Programador/Escritorio")]
        public IActionResult Escritorio()
        {
            var json = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            Usuarios user = JsonConvert.DeserializeObject<Usuarios>(json);
            var usuario_id = user.Id;
            var proyectoQuery = "SELECT P.* FROM proyectos P " +
            "LEFT JOIN proyectos_participantes PP ON PP.proyecto_id = P.id " +
            "LEFT JOIN usuarios U ON U.id = PP.usuario_id " +
            "WHERE U.id = {0}";
            var proyectos = _context.Proyectos.FromSqlRaw(proyectoQuery, user.Id).Count();
            var tickets = _context.Tickets.Where(t => t.AgenteId == usuario_id && (t.Estado != "Finalizado" && t.Estado != "Cancelado")).Count();
            ViewData["nombre"] = user.FullName;
            ViewData["proyectos"] = proyectos;
            ViewData["tickets"] = tickets;
            ViewData["usuario_id"] = usuario_id;
            return View("Views/Programador/Escritorio.cshtml");
        }
    }
}
