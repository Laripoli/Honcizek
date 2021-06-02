using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Honcizek.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System.Security.Claims;

namespace Honcizek.Controllers.Administrador
{
    [Authorize(Roles = "Administrador")]
    [Route("Administrador/[controller]/[action]")]
    public class ProyectosController : Controller
    {
        private readonly honcizekContext _context;

        public ProyectosController(honcizekContext context)
        {
            _context = context;
        }

        // GET: Proyectos
        public async Task<IActionResult> Index(String nombre, String cliente)
        {
            ViewData["error"] = false;
            ViewData["general"] = true;
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
             
            

            ViewData["nombreFilter"] = nombre;
            ViewData["clienteFilter"] = cliente;
            /*if (!String.IsNullOrEmpty(nombre))
            {
                honcizekContext = _context.Proyectos.Where(p => p.Nombre == nombre).Include(p => p.Cliente);
            }*/

            var query = "SELECT P.* FROM proyectos P "+
            "LEFT JOIN clientes C ON C.id = P.cliente_id ";

            if (!String.IsNullOrEmpty(nombre) || !String.IsNullOrEmpty(cliente))
            {
                query += " WHERE ";
                if (!String.IsNullOrEmpty(nombre)) 
                {
                    query += " P.nombre like '%"+nombre+"%'";
                }
                if(!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(cliente))
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

            var honcizekContext = _context.Proyectos.FromSqlRaw(query).Include(p => p.Cliente);


            return View("Views/Administrador/Proyectos/Index.cshtml",await honcizekContext.ToListAsync());
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
            var query = "SELECT P.* FROM proyectos P " +
            "LEFT JOIN proyectos_participantes PP ON PP.proyecto_id = P.id " +
            "LEFT JOIN usuarios U ON U.id = PP.usuario_id " +
            "LEFT JOIN clientes C ON C.id = P.cliente_id " +
            "WHERE U.id = {0}";

             
            ViewData["general"] = false;

            ViewData["nombreFilter"] = nombre;
            ViewData["clienteFilter"] = cliente;


                if (!String.IsNullOrEmpty(nombre))
                {
                    query += " AND P.nombre like '%" + nombre + "%'";
                }
                if(!String.IsNullOrEmpty(cliente))
                {
                    query += " AND (CONCAT(C.nombre,' ',C.apellidos) LIKE '%" + cliente + "%'" +
                         " OR C.razon_social like '%" + cliente + "%')";
            }
            
            var honcizekContext = _context.Proyectos.FromSqlRaw(query, Id).Include(p => p.Cliente);
            return View("Views/Administrador/Proyectos/Index.cshtml", await honcizekContext.ToListAsync());
        }

        [HttpPost]
        public int prueba(int proyecto_id)
        {
            return proyecto_id;
        }

        // GET: Proyectos/Create
        public IActionResult Create()
        {
            DateTime hoy = DateTime.Today;
            ViewData["hoy"] = hoy.ToString("d");
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "FullName");
            ViewData["Tipo"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Cliente", Value = "Cliente"},
                    new SelectListItem {Text = "Interno", Value = "Interno"}
                };
            ViewData["Estado"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Pendiente", Value = "Pendiente"},
                    new SelectListItem {Text = "En curso", Value = "En curso"},
                    new SelectListItem {Text = "Finalizado", Value = "Finalizado"}
                };
            return View("Views/Administrador/Proyectos/Create.cshtml");
        }

        // POST: Proyectos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClienteId,Tipo,Nombre,Descripcion,DescripcionDesarrollo,FechaRegistro,FechaInicio,FechaFinPrevista,FechaFinReal,HorasInternasPrevistas,Estado,Fase")] Proyectos proyectos)
        {
            if (ModelState.IsValid)
            {
                if(proyectos.Fase == "Diseno")
                {
                    proyectos.Fase = "Dise�o";
                }
                _context.Add(proyectos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "FullName");
            ViewData["Tipo"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Cliente", Value = "Cliente",Selected = (proyectos.Tipo=="Cliente")?true:false},
                    new SelectListItem {Text = "Interno", Value = "Interno",Selected = (proyectos.Tipo=="Interno")?true:false}
                };
            ViewData["Estado"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Pendiente", Value = "Pendiente",Selected = (proyectos.Estado=="Pendiente")?true:false},
                    new SelectListItem {Text = "En curso", Value = "En curso",Selected = (proyectos.Estado=="En curso")?true:false},
                    new SelectListItem {Text = "Finalizado", Value = "Finalizado",Selected = (proyectos.Estado=="Finalizado")?true:false}
                };
            DateTime hoy = DateTime.Today;
            ViewData["hoy"] = hoy.ToString("d");
            return View("Views/Administrador/Proyectos/Create.cshtml",proyectos);
        }

        // GET: Proyectos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proyectos = await _context.Proyectos.FindAsync(id);
            if (proyectos == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "FullName", proyectos.ClienteId);
            ViewData["Tipo"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Cliente", Value = "Cliente"},
                    new SelectListItem {Text = "Interno", Value = "Interno"}
                };
            ViewData["Estado"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Pendiente", Value = "Pendiente"},
                    new SelectListItem {Text = "En curso", Value = "En curso"},
                    new SelectListItem {Text = "Finalizado", Value = "Finalizado"}
                };
            proyectos.Fase = proyectos.Fase == "Dise�o" ? "Diseno" : proyectos.Fase;
            return View("Views/Administrador/Proyectos/Edit.cshtml",proyectos);
        }

        // POST: Proyectos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClienteId,Tipo,Nombre,Descripcion,DescripcionDesarrollo,FechaRegistro,FechaInicio,FechaFinPrevista,FechaFinReal,HorasInternasPrevistas,Estado,Fase")] Proyectos proyectos)
        {
            if (id != proyectos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proyectos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProyectosExists(proyectos.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "FullName", proyectos.ClienteId);
            return View("Views/Administrador/Proyectos/Edit.cshtml",proyectos);
        }

        // GET: Proyectos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proyectos = await _context.Proyectos
                .Include(p => p.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proyectos == null)
            {
                return NotFound();
            }

            return View("Views/Administrador/Proyectos/Delete.cshtml",proyectos);
        }

        // POST: Proyectos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proyectos = await _context.Proyectos.FindAsync(id);
            _context.Proyectos.Remove(proyectos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProyectosExists(int id)
        {
            return _context.Proyectos.Any(e => e.Id == id);
        }
    }
}
