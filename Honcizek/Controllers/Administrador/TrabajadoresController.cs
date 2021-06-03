using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Honcizek.DAL.Models;
using System.Text;

namespace Honcizek.Controllers_Administrador
{
    /// <summary>
    /// Controlador de trabajadores
    /// </summary>
	[Authorize(Roles = "Administrador")]
	[Route("Administrador/[controller]/[action]")]
    public class TrabajadoresController : Controller
    {
        private readonly honcizekContext _context;

        public TrabajadoresController(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Redirecciona al listado de trabajadores
        /// Gestiona tanto el listado como el listado filtrado
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            return View("Views/Administrador/Trabajadores/Index.cshtml", await _context.Usuarios.OrderBy(u=> u.Nombre).ToListAsync());
        }

        /// <summary>
        /// Redirecciona a la creación de un trabajador
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            ViewData["login-error"] = false;
            ViewData["Puesto"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Administrador", Value = "Administrador"},
                    new SelectListItem {Text = "Programador", Value = "Programador"}
                };
            return View("Views/Administrador/Trabajadores/Create.cshtml");
        }

        /// <summary>
        /// Valida y guarda el trabajador y redirecciona al listado, en caso de error vuelve a la creación
        /// </summary>
        /// <param name="usuarios"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Login,Nombre,Apellidos,Clave,Email,Puesto")] Usuarios usuarios)
        {
            ViewData["login-error"] = false;
            if (!login_check(usuarios.Login))
            {
                if (ModelState.IsValid)
                {
                    usuarios.Clave = CreateMD5(usuarios.Clave);
                    _context.Add(usuarios);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                ViewData["login-error"] = true;
            }
            ViewData["Puesto"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Administrador", Value = "Administrador",Selected = (usuarios.Puesto=="Administrador")?true:false},
                    new SelectListItem {Text = "Programador", Value = "Programador",Selected = (usuarios.Puesto=="Programador")?true:false}
                };
            return View("Views/Administrador/Trabajadores/Create.cshtml",usuarios);
        }

        /// <summary>
        /// Redirecciona a la edición del trabajador
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["login-error"] = false;
            var usuarios = await _context.Usuarios.FindAsync(id);
            if (usuarios == null)
            {
                return NotFound();
            }
            ViewData["Puesto"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Administrador", Value = "Administrador",Selected = (usuarios.Puesto=="Administrador")?true:false},
                    new SelectListItem {Text = "Programador", Value = "Programador",Selected = (usuarios.Puesto=="Programador")?true:false}
                };
            return View("Views/Administrador/Trabajadores/Edit.cshtml",usuarios);
        }

        /// <summary>
        /// Valida y actualiza el trabajador y redirecciona al listado, en caso de error vuelve a la edición
        /// </summary>
        /// <param name="id"></param>
        /// <param name="usuarios"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Login,Nombre,Apellidos,Clave,Email,Puesto")] Usuarios usuarios)
        {
            if (id != usuarios.Id)
            {
                return NotFound();
            }
            ViewData["login-error"] = false;
            if (!login_check(usuarios.Id,usuarios.Login))
            {

                if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuariosExists(usuarios.Id))
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
            }
            else
            {
                ViewData["login-error"] = true;
            }
            ViewData["Puesto"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Administrador", Value = "Administrador",Selected = (usuarios.Puesto=="Administrador")?true:false},
                    new SelectListItem {Text = "Programador", Value = "Programador",Selected = (usuarios.Puesto=="Programador")?true:false}
                };
            return View("Views/Administrador/Trabajadores/Edit.cshtml",usuarios);
        }

        /// <summary>
        /// Redirecciona a la eliminación del trabajador
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarios = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarios == null)
            {
                return NotFound();
            }

            return View("Views/Administrador/Trabajadores/Delete.cshtml",usuarios);
        }

        /// <summary>
        /// Elimina el trabajador y redirecciona al listado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarios = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuarios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Comprueba si el trabajador existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool UsuariosExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }

        /// <summary>
        /// Comprueba si el login ya existe
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public bool login_check(string login)
        {
            return _context.Usuarios.Any(e => e.Login == login);
        }

        /// <summary>
        /// Comprueba si el login ya existe y pertenece a otro trabajador
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Login"></param>
        /// <returns></returns>
        public bool login_check(int Id,string Login)
        {
            return _context.Usuarios.Any(e => e.Login == Login && e.Id!= Id);
        }

        /// <summary>
        /// Crea un hash md5 del string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
