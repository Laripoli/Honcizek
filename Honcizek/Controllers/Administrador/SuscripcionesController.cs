using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Honcizek.DAL.Models;
using System.Text.Json;
using System.Security.Claims;

namespace Honcizek.Controllers_Administrador
{
    /// <summary>
    /// Controlador de suscripciones
    /// </summary>
	[Authorize(Roles = "Administrador")]
	[Route("Administrador/[controller]/[action]")]
    public class SuscripcionesController : Controller
    {
        private readonly honcizekContext _context;

        public SuscripcionesController(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Redirecciona al listado de suscripciones
        /// Gestiona tanto el listado como el filtrado de suscripciones
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(String nombre, String cliente)
        {
            
            ViewData["error"] = false;
            ViewData["general"] = true;
            ViewData["nombreFilter"] = nombre;
            ViewData["clienteFilter"] = cliente;

            var query = "SELECT S.* FROM suscripciones S " +
                "LEFT JOIN usuarios U ON U.id = S.agente_id " +
                "LEFT JOIN clientes C ON C.id = S.cliente_id " +
                "LEFT JOIN proyectos P ON S.id = S.proyecto_id ";

            if (!String.IsNullOrEmpty(nombre) || !String.IsNullOrEmpty(cliente))
            {
                query += " WHERE ";
                if (!String.IsNullOrEmpty(nombre))
                {
                    query += " S.nombre like '%" + nombre + "%'";
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
            var honcizekContext = _context.Suscripciones.FromSqlRaw(query).Include(s => s.Agente).Include(s => s.Cliente).Include(s => s.Proyecto);
            return View("Views/Administrador/Suscripciones/Index.cshtml",await honcizekContext.ToListAsync());
        }

        /// <summary>
        /// Redirecciona al listado de suscripciones en las que participa el usuario
        /// Gestiona tanto el listado como el listado filtrado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
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

            var query = "SELECT S.* FROM suscripciones S " +
                "LEFT JOIN usuarios U ON U.id = S.agente_id " +
                "LEFT JOIN clientes C ON C.id = S.cliente_id " +
                "LEFT JOIN proyectos P ON S.id = S.proyecto_id "+
                "WHERE S.agente_id = {0}";

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

            var honcizekContext = _context.Suscripciones.FromSqlRaw(query,Id).Include(s => s.Agente).Include(s => s.Cliente).Include(s => s.Proyecto);

            return View("Views/Administrador/Suscripciones/Index.cshtml", await honcizekContext.ToListAsync());
        }

        /// <summary>
        /// Redirecciona a la creación de una nueva suscripción
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            DateTime hoy = DateTime.Today;
            ViewData["hoy"] = hoy.ToString("yyyy-MM-dd");
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "FullName");
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "FullName");
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Nombre");
            ViewData["Tipo"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Software", Value = "Software"},
                    new SelectListItem {Text = "Hosting", Value = "Hosting"},
                    new SelectListItem {Text = "Hardware", Value = "Hardware"}
                };
            ViewData["Periodicidad"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Anual", Value = "Anual"},
                    new SelectListItem {Text = "Mensual", Value = "Mensual"},
                    new SelectListItem {Text = "Trimestral", Value = "Trimestral"},
                    new SelectListItem {Text = "Semestral", Value = "Semestral"},
                    new SelectListItem {Text = "Abierta", Value = "Abierta"}
                };
            return View("Views/Administrador/Suscripciones/Create.cshtml");
        }

        /// <summary>
        /// Valida y guarda la nueva suscripción, en caso de error devuelve a la vista de creación
        /// </summary>
        /// <param name="suscripciones"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClienteId,Tipo,Nombre,ProyectoId,AgenteId,FechaDesde,FechaHasta,Renovacion,PrecioAlta,PrecioPeriodo,Periodicidad,Observaciones")] Suscripciones suscripciones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suscripciones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            DateTime hoy = DateTime.Today;
            ViewData["hoy"] = hoy.ToString("yyyy-MM-dd");
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
            return View("Views/Administrador/Suscripciones/Create.cshtml",suscripciones);
        }

        /// <summary>
        /// Redirecciona a la vista de edición de un usuario
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
            return View("Views/Administrador/Suscripciones/Edit.cshtml",suscripciones);
        }

        /// <summary>
        /// Valida y actualiza la suscripción y redirecciona al listado, en caso de error devuelve a la edición
        /// </summary>
        /// <param name="id"></param>
        /// <param name="suscripciones"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClienteId,Tipo,Nombre,ProyectoId,AgenteId,FechaDesde,FechaHasta,Renovacion,PrecioAlta,PrecioPeriodo,Periodicidad,Observaciones")] Suscripciones suscripciones)
        {
            if (id != suscripciones.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suscripciones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuscripcionesExists(suscripciones.Id))
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
            return View("Views/Administrador/Suscripciones/Edit.cshtml",suscripciones);
        }

        /// <summary>
        /// Redirecciona a la vista de eliminación de suscripción
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suscripciones = await _context.Suscripciones
                .Include(s => s.Agente)
                .Include(s => s.Cliente)
                .Include(s => s.Proyecto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suscripciones == null)
            {
                return NotFound();
            }

            return View("Views/Administrador/Suscripciones/Delete.cshtml",suscripciones);
        }

        /// <summary>
        /// Elimina la suscripción y redirecciona al listado de suscripciones
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suscripciones = await _context.Suscripciones.FindAsync(id);
            _context.Suscripciones.Remove(suscripciones);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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

        /// <summary>
        /// Carga los proyectos de un cliente
        /// </summary>
        /// <param name="cliente_id"></param>
        /// <returns></returns>
        [HttpPost]
        public string cargar_proyectos(int cliente_id)
        {
            var proyectos = _context.Proyectos.Where(p => p.ClienteId == cliente_id);

            return JsonSerializer.Serialize(proyectos);
        }

    }
}
