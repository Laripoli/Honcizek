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
    /// <summary>
    /// Controlador de suscripciones en las que participa el programador
    /// </summary>
	[Authorize(Roles = "Programador")]
	[Route("Programador/[controller]/[action]")]
    public class SuscripcionesPController : Controller
    {
        private readonly honcizekContext _context;

        public SuscripcionesPController(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Redirecciona al listado de suscripciones en las que participa el usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(String nombre, String cliente)
        {
            var query = "SELECT S.* FROM suscripciones S " +
                "LEFT JOIN usuarios U ON U.id = S.agente_id " +
                "LEFT JOIN clientes C ON C.id = S.cliente_id " +
                "LEFT JOIN proyectos P ON S.id = S.proyecto_id " +
                "WHERE S.agente_id = {0} AND S.fecha_hasta >= {1}";
            DateTime hoy = DateTime.Now;
            var fecha = hoy.ToString("yyyy-MM-dd");
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            var usuario = await _context.Usuarios.FindAsync(Id);
            ViewData["error"] = false;
            if (usuario == null)
            {
                ViewData["error"] = true;
            }
            if (!String.IsNullOrEmpty(nombre))
            {
                query += " AND S.nombre like '%" + nombre + "%'";
            }
            if (!String.IsNullOrEmpty(cliente))
            {
                query += " AND (CONCAT(C.nombre,' ',C.apellidos) LIKE '%" + cliente + "%'" +
                     " OR C.razon_social like '%" + cliente + "%')";
            }
            ViewData["nombreFilter"] = nombre;
            ViewData["clienteFilter"] = cliente;

            var honcizekContext = _context.Suscripciones.FromSqlRaw(query,Id,fecha).Include(s => s.Agente).Include(s => s.Cliente).Include(s => s.Proyecto);
            return View("Views/Programador/Suscripciones/Index.cshtml",await honcizekContext.ToListAsync());
        }

        /// <summary>
        /// Redirecciona a la ficha de la suscripción
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suscripciones = await _context.Suscripciones.FindAsync(id);
            if (suscripciones == null)
            {
                return NotFound();
            }
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName", suscripciones.AgenteId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "FullName", suscripciones.ClienteId);
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Nombre", suscripciones.ProyectoId);
            ViewData["Tipo"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Software", Value = "Software",Selected = (suscripciones.Tipo=="Software")?true:false},
                    new SelectListItem {Text = "Hosting", Value = "Hosting",Selected = (suscripciones.Tipo=="Hosting")?true:false},
                    new SelectListItem {Text = "Hardware", Value = "Hardware",Selected = (suscripciones.Tipo=="Hardware")?true:false}
                };
            ViewData["Periodicidad"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Anual", Value = "Anual",Selected = (suscripciones.Periodicidad=="Anual")?true:false},
                    new SelectListItem {Text = "Mensual", Value = "Mensual",Selected = (suscripciones.Periodicidad=="Mensual")?true:false},
                    new SelectListItem {Text = "Trimestral", Value = "Trimestral",Selected = (suscripciones.Periodicidad=="Trimestral")?true:false},
                    new SelectListItem {Text = "Semestral", Value = "Semestral",Selected = (suscripciones.Periodicidad=="Semestral")?true:false},
                    new SelectListItem {Text = "Abierta", Value = "Abierta",Selected = (suscripciones.Periodicidad=="Abierta")?true:false}
                };
            return View("Views/Programador/Suscripciones/Edit.cshtml",suscripciones);
        }
        /// <summary>
        /// Comprueba si la suscripción existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool SuscripcionesExists(int id)
        {
            return _context.Suscripciones.Any(e => e.Id == id);
        }
    }
}
