using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Honcizek.DAL.Models;

namespace Honcizek.Controllers_Administrador
{
	[Authorize(Roles = "Administrador")]
	[Route("Administrador/[controller]/[action]")]
    public class SuscripcionesController : Controller
    {
        private readonly honcizekContext _context;

        public SuscripcionesController(honcizekContext context)
        {
            _context = context;
        }

        // GET: Suscripciones
        public async Task<IActionResult> Index()
        {
            var honcizekContext = _context.Suscripciones.Include(s => s.Agente).Include(s => s.Cliente).Include(s => s.Proyecto);
            return View("Views/Administrador/Suscripciones/Index.cshtml",await honcizekContext.ToListAsync());
        }

        // GET: Suscripciones/Details/5
        public async Task<IActionResult> Details(int? id)
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

            return View("Views/Administrador/Suscripciones/Details.cshtml",suscripciones);
        }

        // GET: Suscripciones/Create
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

        // POST: Suscripciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Suscripciones/Edit/5
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

        // POST: Suscripciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Suscripciones/Delete/5
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

        // POST: Suscripciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suscripciones = await _context.Suscripciones.FindAsync(id);
            _context.Suscripciones.Remove(suscripciones);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuscripcionesExists(int id)
        {
            return _context.Suscripciones.Any(e => e.Id == id);
        }
    }
}
