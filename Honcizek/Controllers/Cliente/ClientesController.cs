using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Honcizek.DAL.Models;
using System.Security.Claims;

namespace Honcizek.Controllers.Cliente
{
	[Authorize(Roles = "Cliente")]
	[Route("[controller]/[action]")]
    public class ClientesCController : Controller
    {
        private readonly honcizekContext _context;

        public ClientesCController(honcizekContext context)
        {
            _context = context;
        }

        [Route("/MiPerfil")]
        public async Task<IActionResult> MiPerfil()
        {
            var id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
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
            ViewData["guardado"] = false;
            var clientes = await _context.Clientes.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }
            ViewData["LocalidadId"] = new SelectList(_context.Localidades, "Id", "Nombre", clientes.LocalidadId);

            ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "Id", "Nombre", clientes.ProvinciaId);
            return View("Views/Cliente/Clientes/Edit.cshtml",clientes);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Login,Clave,LocalidadId,ProvinciaId,FechaRegistro,Tipo,RazonSocial,Nombre,Apellidos,Nifcif,Telefono,Movil,Email,Direccion,Cp,Observaciones")] Clientes clientes)
        {
            var Id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.UserData)?.Value);
            id = Id;
            if (id != clientes.Id)
            {
                return NotFound();
            }
            ViewData["login-error"] = false;
            ViewData["guardado"] = false;
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
                    ViewData["guardado"] = true;
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
            return View("Views/Cliente/Clientes/Edit.cshtml",clientes);
        }

        private bool ClientesExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
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
    }
}
