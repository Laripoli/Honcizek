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
using System.Text;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Honcizek.Controllers.Administrador
{
    [Authorize(Roles = "Administrador")]
    [Route("Administrador/[controller]/[action]")]
    public class ClientesController : Controller
    {
        private readonly honcizekContext _context;

        public ClientesController(honcizekContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(String search)
        {
            ViewData["CurrentFilter"] = search;
            var honcizekContext = _context.Clientes.Include(c => c.Localidad).Include(c => c.Pais).Include(c => c.Provincia);

            if (!String.IsNullOrEmpty(search))
            {

                honcizekContext = _context.Clientes.Where(s => s.Apellidos.Contains(search)
                               || s.Nombre.Contains(search)).Include(c => c.Localidad).Include(c => c.Pais).Include(c => c.Provincia);

            }
            


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
            ViewData["login-error"] = false;
            DateTime hoy = DateTime.Today;
            ViewData["hoy"] = hoy.ToString("d");
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
            ViewData["login-error"] = false;
            if (!login_check(clientes.Login))
            {
                if (ModelState.IsValid)
                {
                    clientes.Clave = CreateMD5(clientes.Clave);
                    _context.Add(clientes);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                ViewData["login-error"] = true;
            }
            ViewData["LocalidadId"] = new SelectList(_context.Localidades, "Id", "Nombre", clientes.LocalidadId);
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre", clientes.PaisId);
            ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "Id", "Nombre", clientes.ProvinciaId);
            ViewData["Tipo"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Empresa", Value = "Empresa",Selected = (clientes.Tipo=="Empresa")?true:false},
                    new SelectListItem {Text = "Persona", Value = "Persona",Selected = (clientes.Tipo=="Persona")?true:false}
                };
            return View("Views/Administrador/Clientes/Create.cshtml", clientes);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["login-error"] = false;
            ViewData["Tipo"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Empresa", Value = "Empresa"},
                    new SelectListItem {Text = "Persona", Value = "Persona"}
                };
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
            ViewData["login-error"] = false;

            if (!login_check(clientes.Id, clientes.Login))
            {
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
            }
            else
            {
                ViewData["login-error"] = true;
            }

            ViewData["LocalidadId"] = new SelectList(_context.Localidades, "Id", "Nombre", clientes.LocalidadId);
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre", clientes.PaisId);
            ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "Id", "Nombre", clientes.ProvinciaId);
            ViewData["Tipo"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Empresa", Value = "Empresa",Selected = (clientes.Tipo=="Empresa")?true:false},
                    new SelectListItem {Text = "Persona", Value = "Persona",Selected = (clientes.Tipo=="Persona")?true:false}
                };
            return View("Views/Administrador/Clientes/Edit.cshtml", clientes);
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

        public bool login_check(string login)
        {
            return _context.Clientes.Any(e => e.Login == login);
        }

        public bool login_check(int Id, string Login)
        {
            return _context.Clientes.Any(e => e.Login == Login && e.Id != Id);
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

        [HttpPost]
        public string cargar_localidades(int provincia_id)
        {
            List<string> list = new List<string>();
            var localidades = _context.Localidades.Where(l => l.ProvinciaId == provincia_id);
            
            IEnumerable<string> ids = list;
            return JsonSerializer.Serialize(localidades);
        }

    }
}
