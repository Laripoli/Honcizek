﻿using Honcizek.BL.Contracts;
using Honcizek.Core.DTO;
using Honcizek.DAL.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Honcizek.Controllers
{
    public class LoginController : Controller
    {
        /*private readonly ILogger<LoginController> _logger;*/
        public IUsuarioBL _usuarioBL { get; set; }

        public LoginController(IUsuarioBL usuarioBL)
        {
            /*_logger = logger;*/
            _usuarioBL = usuarioBL;
        }

         public IActionResult Login()
         {
            return View();
         }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password, string ReturnUrl)
        {
            UsuarioDTO usuarioDTO = _usuarioBL.Login(new UsuarioDTO
            {
                Login = username,
                Password = password
            });
            if (usuarioDTO != null)
            {
                var str = JsonConvert.SerializeObject(usuarioDTO);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuarioDTO.Nombre),
                    new Claim(ClaimTypes.NameIdentifier, str),
                    new Claim(ClaimTypes.Role, usuarioDTO.Tipo)
                };

                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                var a = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return Redirect("/"+ usuarioDTO.Tipo +"/Escritorio");
            }
            else {
                ViewData["Error"] = (ReturnUrl.Length > 0) ? "Usuario incorrecto" : "Debes iniciar sesión para acceder";
                return View(); }
        }
    }
}
