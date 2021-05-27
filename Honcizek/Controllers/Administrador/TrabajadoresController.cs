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
	[Authorize(Roles = "Administrador")]
	[Route("Administrador/[controller]/[action]")]
    public class TrabajadoresController : Controller
    {
        private readonly honcizekContext _context;

        public TrabajadoresController(honcizekContext context)
        {
            _context = context;
        }

        // GET: Trabajadores
        public async Task<IActionResult> Index()
        {
            return View("Views/Administrador/Trabajadores/Index.cshtml", await _context.Usuarios.OrderBy(u=> u.Nombre).ToListAsync());
        }

        // GET: Trabajadores/Details/5
        public async Task<IActionResult> Details(int? id)
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

            return View("Views/Administrador/Trabajadores/Details.cshtml",usuarios);
        }

        // GET: Trabajadores/Create
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

        // POST: Trabajadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Trabajadores/Edit/5
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

        // POST: Trabajadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Trabajadores/Delete/5
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

        // POST: Trabajadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarios = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuarios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuariosExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }

        public bool login_check(string login)
        {
            return _context.Usuarios.Any(e => e.Login == login);
        }

        public bool login_check(int Id,string Login)
        {
            return _context.Usuarios.Any(e => e.Login == Login && e.Id!= Id);
        }

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
