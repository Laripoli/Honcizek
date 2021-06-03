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
    /// <summary>
    /// Gestiona la entidad clientes del lado administrador
    /// </summary>
    [Authorize(Roles = "Administrador")]
    [Route("Administrador/[controller]/[action]")]
    public class ClientesController : Controller
    {
        private readonly honcizekContext _context;

        public ClientesController(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Listado de clientes tanto general como filtrado
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(String search)
        {
            ViewData["CurrentFilter"] = search;
            var query = "SELECT C.* FROM clientes C " +
                "LEFT JOIN localidades L ON L.id = C.localidad_id " +
                "LEFT JOIN provincias P ON P.id = C.provincia_id ";
            if (!String.IsNullOrEmpty(search))
            {
                query += "WHERE CONCAT(C.nombre,' ',C.apellidos) LIKE '%" + search + "%'" +
                         " OR C.razon_social like '%" + search + "%'" ;

            }
            
            var honcizekContext = _context.Clientes.FromSqlRaw(query).Include(c => c.Localidad).Include(c => c.Provincia);


            return View("Views/Administrador/Clientes/Index.cshtml", await honcizekContext.ToListAsync());
        }

        /// <summary>
        /// Redirección a la vista de crear un cliente
        /// </summary>
        /// <returns></returns>
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
             
            ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "Id", "Nombre");
            return View("Views/Administrador/Clientes/Create.cshtml");
        }

        /// <summary>
        /// Validación del cliente creado y en caso de error devuelve a la vista de creación de cliente
        /// </summary>
        /// <param name="clientes"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Login,Clave,LocalidadId,ProvinciaId,FechaRegistro,Tipo,RazonSocial,Nombre,Apellidos,Nifcif,Telefono,Movil,Email,Direccion,Cp,Observaciones")] Clientes clientes)
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
             
            ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "Id", "Nombre", clientes.ProvinciaId);
            ViewData["Tipo"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Empresa", Value = "Empresa",Selected = (clientes.Tipo=="Empresa")?true:false},
                    new SelectListItem {Text = "Persona", Value = "Persona",Selected = (clientes.Tipo=="Persona")?true:false}
                };
            return View("Views/Administrador/Clientes/Create.cshtml", clientes);
        }

        /// <summary>
        /// Redireccion a la vista de edición de un cliente en base al id pasado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
             
            ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "Id", "Nombre", clientes.ProvinciaId);
            return View("Views/Administrador/Clientes/Edit.cshtml", clientes);
        }

        /// <summary>
        /// Validación y guardado del cliente editado, en caso de error devuelve a la vista de edición
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clientes"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Login,Clave,LocalidadId,ProvinciaId,FechaRegistro,Tipo,RazonSocial,Nombre,Apellidos,Nifcif,Telefono,Movil,Email,Direccion,Cp,Observaciones")] Clientes clientes)
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
             
            ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "Id", "Nombre", clientes.ProvinciaId);
            ViewData["Tipo"] = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Empresa", Value = "Empresa",Selected = (clientes.Tipo=="Empresa")?true:false},
                    new SelectListItem {Text = "Persona", Value = "Persona",Selected = (clientes.Tipo=="Persona")?true:false}
                };
            return View("Views/Administrador/Clientes/Edit.cshtml", clientes);
        }

        /// <summary>
        /// Devuelve la vista de eliminación de un cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes
               .Include(c => c.Localidad)
                 
               .Include(c => c.Provincia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientes == null)
            {
                return NotFound();
            }

            return View("Views/Administrador/Clientes/Delete.cshtml", clientes);
        }

        /// <summary>
        /// Elimina el cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientes = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(clientes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Comprueba si existe el cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool ClientesExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }


        /// <summary>
        /// Comprueba que el login aportado no exista
        /// </summary>
        /// <param name="login"></param>
        /// <returns>True si está intentando utilizar un login ya existente</returns>
        public bool login_check(string login)
        {
            return _context.Clientes.Any(e => e.Login == login);
        }
       
        /// <summary>
        /// Comprueba si el login aportado ya existe y no pertenece al cliente
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Login"></param>
        /// <returns>True si está intentando utilizar un login ya existente utilizado por otro cliente</returns>
        public bool login_check(int Id, string Login)
        {
            return _context.Clientes.Any(e => e.Login == Login && e.Id != Id);
        }

        /// <summary>
        /// Crea un hash md5 basado en el string pasado como parametro
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
        
        /// <summary>
        /// Carga las localidades en base al id de provincia aportado
        /// </summary>
        /// <param name="provincia_id"></param>
        /// <returns></returns>
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
