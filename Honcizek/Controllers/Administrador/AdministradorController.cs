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
using Microsoft.AspNetCore.Authentication;

namespace Honcizek.Controllers.Administrador
{
    /// <summary>
    /// Gestiona el escritorio del lado administrador
    /// </summary>
    [Authorize(Roles = "Administrador")]
    public class AdministradorController : Controller
    {
        private readonly honcizekContext _context;

        public AdministradorController(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Redirecciona al escritorio de administradores
        /// </summary>
        /// <returns></returns>
        [Route("Administrador/Escritorio")]
        public async Task<IActionResult> Escritorio()
        {
            DateTime hoy = DateTime.Now;
            var fecha = hoy.ToString("yyyy-MM-dd");
            var usuario_id = 0;
            try
            {
            usuario_id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            if (usuario_id == 0)
            {
            await HttpContext.SignOutAsync();

            }

            }catch(Exception e)
            {
                await HttpContext.SignOutAsync();
                return NotFound();
            }
            var proyectoQuery = "SELECT P.* FROM proyectos P " +
            "LEFT JOIN proyectos_participantes PP ON PP.proyecto_id = P.id " +
            "LEFT JOIN usuarios U ON U.id = PP.usuario_id " +
            "WHERE U.id = {0}";

            var proyectos = _context.Proyectos.FromSqlRaw(proyectoQuery, usuario_id).Count();
            var tickets = _context.Tickets.Where(t =>t.AgenteId == usuario_id && (t.Estado != "Finalizado" && t.Estado != "Cancelado")).Count();
            var suscripciones = _context.Suscripciones.Where(s => s.AgenteId == usuario_id && s.FechaHasta > hoy).Count();

            ViewData["nombre"] = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;
            ViewData["proyectos"] = proyectos;
            ViewData["tickets"] = tickets;
             
            ViewData["suscripciones"] = suscripciones;

            return View("Views/Administrador/Escritorio.cshtml");
        }
    }
}
