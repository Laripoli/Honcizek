﻿using Honcizek.DAL.Models;
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
    [Authorize(Roles = "Cliente")]
    public class ClienteController : Controller
    {
        private readonly honcizekContext _context;

        public ClienteController(honcizekContext context)
        {
            _context = context;
        }

        [Route("Escritorio")]
        public IActionResult Escritorio()
        {
            DateTime hoy = DateTime.Now;
            var fecha = hoy.ToString("yyyy-MM-dd");
            var usuario_id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
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
            ViewData["layout"] = "Administrador";
            ViewData["suscripciones"] = suscripciones;

            return View("Views/Cliente/Escritorio.cshtml");
        }
    }
}
