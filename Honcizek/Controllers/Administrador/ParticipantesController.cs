using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Honcizek.DAL.Models;
using System.Collections;

namespace Honcizek.Controllers_Administrador
{
	[Authorize(Roles = "Administrador")]
	[Route("Administrador/[controller]/[action]")]
    public class ParticipantesController : Controller
    {
        private readonly honcizekContext _context;

        public ParticipantesController(honcizekContext context)
        {
            _context = context;
        }

        // GET: Participantes
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["error"] = false;
            var proyectos = await _context.Proyectos.FindAsync(id);
            if (proyectos == null)
            {
                ViewData["error"] = true;
            }
            string query = "Select * from proyectos_participantes where proyecto_id= {0}";
            var honcizekContext = _context.ProyectosParticipantes.FromSqlRaw(query, id).Include(t => t.Proyecto).Include(t => t.Usuario);
            /*var honcizekContext = _context.Trabajos.Include(t => t.Proyecto);*/
            ViewData["proyecto_id"] = id;

            /*var honcizekContext = _context.ProyectosParticipantes.Include(p => p.Proyecto).Include(p => p.Usuario);*/
            return View("Views/Administrador/Participantes/Index.cshtml",await honcizekContext.ToListAsync());
        }

        // GET: Participantes/Create
        public async Task<IActionResult> Create(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["error"] = false;
            ViewData["lleno"] = false;
            var proyectos = await _context.Proyectos.FindAsync(id);
            if (proyectos == null)
            {
                ViewData["error"] = true;
            }

            var usuariosExistentes = _context.Usuarios.FromSqlRaw("SELECT U.* FROM usuarios U" +
                " LEFT JOIN proyectos_participantes PP ON U.id = PP.usuario_id"+
                " WHERE PP.proyecto_id = 10").ToList();
            var usuarios = _context.Usuarios.ToList();
            var usuariosNoElegidos = new List<Usuarios>();
            foreach(Usuarios usuario in usuarios)
            {
                bool repetido = false;
                foreach(Usuarios seleccionado in usuariosExistentes)
                {
                    if(usuario.Id == seleccionado.Id)
                    {
                        repetido = true;
                        break;
                    }
                }
                if (!repetido)
                {
                    usuariosNoElegidos.Add(usuario);
                }
            }
            if(!(usuariosNoElegidos.Count() > 0))
            {
                ViewData["lleno"] = true;
            }
            ViewData["UsuarioId"] = new SelectList(usuariosNoElegidos, "Id", "FullName");
            ViewData["proyecto_id"] = id;
            return View("Views/Administrador/Participantes/Create.cshtml");
        }

        // POST: Participantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProyectoId,UsuarioId")] ProyectosParticipantes proyectosParticipantes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proyectosParticipantes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { id = proyectosParticipantes.ProyectoId });
            }
            ViewData["proyecto_id"] = proyectosParticipantes.ProyectoId;
            var usuariosExistentes = _context.Usuarios.FromSqlRaw("SELECT U.* FROM usuarios U" +
                " LEFT JOIN proyectos_participantes PP ON U.id = PP.usuario_id" +
                " WHERE PP.proyecto_id = 10").ToList();
            var usuarios = _context.Usuarios.ToList();
            var usuariosNoElegidos = new List<Usuarios>();
            foreach (Usuarios usuario in usuarios)
            {
                bool repetido = false;
                foreach (Usuarios seleccionado in usuariosExistentes)
                {
                    if (usuario.Id == seleccionado.Id)
                    {
                        repetido = true;
                        break;
                    }
                }
                if (!repetido)
                {
                    usuariosNoElegidos.Add(usuario);
                }
            }
            ViewData["UsuarioId"] = new SelectList(usuariosNoElegidos, "Id", "FullName",proyectosParticipantes.UsuarioId);
            return View("Views/Administrador/Participantes/Create.cshtml",proyectosParticipantes);
        }

        // GET: Participantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proyectosParticipantes = await _context.ProyectosParticipantes
                .Include(p => p.Proyecto)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proyectosParticipantes == null)
            {
                return NotFound();
            }

            return View("Views/Administrador/Participantes/Delete.cshtml",proyectosParticipantes);
        }

        // POST: Participantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proyectosParticipantes = await _context.ProyectosParticipantes.FindAsync(id);
            _context.ProyectosParticipantes.Remove(proyectosParticipantes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { id = proyectosParticipantes.ProyectoId });
        }

        private bool ProyectosParticipantesExists(int id)
        {
            return _context.ProyectosParticipantes.Any(e => e.Id == id);
        }
    }
}
