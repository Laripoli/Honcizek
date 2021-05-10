using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Honcizek.Models;

namespace Honcizek.Controllers.Administrador
{
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
            var honcizekContext = _context.Suscripciones.Include(s => s.Agente).Include(s => s.Cliente).Include(s => s.Proyecto).Include(s => s.Servicio);
            return View(await honcizekContext.ToListAsync());
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
                .Include(s => s.Servicio)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suscripciones == null)
            {
                return NotFound();
            }

            return View(suscripciones);
        }

        // GET: Suscripciones/Create
        public IActionResult Create()
        {
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Apellidos");
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Clave");
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Estado");
            ViewData["ServicioId"] = new SelectList(_context.Servicios, "Id", "Nombre");
            return View();
        }

        // POST: Suscripciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ServicioId,ClienteId,ProyectoId,AgenteId,FechaDesde,FechaHasta,HorasContratadas,AvisoCaducidad,ProximidadCaducidad,Renovacion,RenovacionId,Pendiente,Caducada,PrecioAlta,PrecioPeriodo,PrecioConsumoNivel1,PrecioConsumoNivel2,PrecioConsumoNivel3,Periodicidad,Observaciones")] Suscripciones suscripciones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suscripciones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Apellidos", suscripciones.AgenteId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Clave", suscripciones.ClienteId);
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Estado", suscripciones.ProyectoId);
            ViewData["ServicioId"] = new SelectList(_context.Servicios, "Id", "Nombre", suscripciones.ServicioId);
            return View(suscripciones);
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
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Apellidos", suscripciones.AgenteId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Clave", suscripciones.ClienteId);
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Estado", suscripciones.ProyectoId);
            ViewData["ServicioId"] = new SelectList(_context.Servicios, "Id", "Nombre", suscripciones.ServicioId);
            return View(suscripciones);
        }

        // POST: Suscripciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ServicioId,ClienteId,ProyectoId,AgenteId,FechaDesde,FechaHasta,HorasContratadas,AvisoCaducidad,ProximidadCaducidad,Renovacion,RenovacionId,Pendiente,Caducada,PrecioAlta,PrecioPeriodo,PrecioConsumoNivel1,PrecioConsumoNivel2,PrecioConsumoNivel3,Periodicidad,Observaciones")] Suscripciones suscripciones)
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
            ViewData["AgenteId"] = new SelectList(_context.Usuarios, "Id", "Apellidos", suscripciones.AgenteId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Clave", suscripciones.ClienteId);
            ViewData["ProyectoId"] = new SelectList(_context.Proyectos, "Id", "Estado", suscripciones.ProyectoId);
            ViewData["ServicioId"] = new SelectList(_context.Servicios, "Id", "Nombre", suscripciones.ServicioId);
            return View(suscripciones);
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
                .Include(s => s.Servicio)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suscripciones == null)
            {
                return NotFound();
            }

            return View(suscripciones);
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
