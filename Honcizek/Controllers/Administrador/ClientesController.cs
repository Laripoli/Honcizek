using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Honcizek.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Honcizek.Controllers.Administrador
{
    [Route("Administrador/[controller]/[action]")]
    public class ClientesController : Controller
    {
        private readonly honcizekContext _context;

        public ClientesController(honcizekContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var honcizekContext = _context.Clientes.Include(c => c.Localidad).Include(c => c.Pais).Include(c => c.Provincia);
            

            return View("Views/Administrador/Clientes/Index.cshtml", await honcizekContext.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes
                .Include(c => c.Localidad)
                .Include(c => c.Pais)
                .Include(c => c.Provincia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientes == null)
            {
                return NotFound();
            }

            return View("Views/Administrador/Clientes/Details.cshtml", clientes); ;
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            ViewData["Tipo"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Empresa", Value = "Empresa"},
                    new SelectListItem {Text = "Persona", Value = "Persona"}
                };
            ViewData["LocalidadId"] = new SelectList(_context.Localidades, "Id", "Nombre");
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre");
            ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "Id", "Nombre");
            return View("Views/Administrador/Clientes/Create.cshtml");
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Login,Clave,LocalidadId,ProvinciaId,PaisId,FechaRegistro,Tipo,RazonSocial,Nombre,Apellidos,Nifcif,Telefono,Movil,Email,Direccion,Cp,Observaciones")] Clientes clientes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocalidadId"] = new SelectList(_context.Localidades, "Id", "Id", clientes.LocalidadId);
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Id", clientes.PaisId);
            ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "Id", "Id", clientes.ProvinciaId);
            return View("Views/Administrador/Clientes/Index.cshtml", clientes);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }
            ViewData["LocalidadId"] = new SelectList(_context.Localidades, "Id", "Nombre", clientes.LocalidadId);
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre", clientes.PaisId);
            ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "Id", "Nombre", clientes.ProvinciaId);
            return View("Views/Administrador/Clientes/Edit.cshtml", clientes);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Login,Clave,LocalidadId,ProvinciaId,PaisId,FechaRegistro,Tipo,RazonSocial,Nombre,Apellidos,Nifcif,Telefono,Movil,Email,Direccion,Cp,Observaciones")] Clientes clientes)
        {
            if (id != clientes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientesExists(clientes.Id))
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
            ViewData["LocalidadId"] = new SelectList(_context.Localidades, "Id", "Id", clientes.LocalidadId);
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Id", clientes.PaisId);
            ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "Id", "Id", clientes.ProvinciaId);
            return View("Views/Administrador/Clientes/Index.cshtml", clientes);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes
                .Include(c => c.Localidad)
                .Include(c => c.Pais)
                .Include(c => c.Provincia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientes == null)
            {
                return NotFound();
            }

            return View("Views/Administrador/Clientes/Delete.cshtml", clientes);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientes = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(clientes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientesExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
