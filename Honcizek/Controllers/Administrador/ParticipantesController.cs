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
    /// <summary>
    ///  Controlador de participantes de un proyecto
    /// </summary>
	[Authorize(Roles = "Administrador")]
	[Route("Administrador/[controller]/[action]")]
    public class ParticipantesController : Controller
    {
        private readonly honcizekContext _context;

        public ParticipantesController(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        ///  Listado de participantes de un proyecto en concreto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Redirecciona a la vista de añadir participante
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Valida la creación del nuevo participante y redirige al listado, en caso de error devuelve la vista de creación
        /// </summary>
        /// <param name="proyectosParticipantes"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Redirecciona a la vista de eliminación de participante
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Elimina el participante y devuelve al listado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proyectosParticipantes = await _context.ProyectosParticipantes.FindAsync(id);
            _context.ProyectosParticipantes.Remove(proyectosParticipantes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { id = proyectosParticipantes.ProyectoId });
        }
        /// <summary>
        /// Comprueba si el participante existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool ProyectosParticipantesExists(int id)
        {
            return _context.ProyectosParticipantes.Any(e => e.Id == id);
        }
    }
}
