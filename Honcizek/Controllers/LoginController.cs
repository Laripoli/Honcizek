using Honcizek.BL.Contracts;
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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Honcizek.Controllers
{
    [Route("[action]")]
    public class LoginController : Controller
    {
        /*private readonly ILogger<LoginController> _logger;*/
        public IUsuarioBL _usuarioBL { get; set; }

        public LoginController(IUsuarioBL usuarioBL)
        {
            /*_logger = logger;*/
            _usuarioBL = usuarioBL;
        }

        public IActionResult Admin()
         {
            var rol = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;
            if (!String.IsNullOrEmpty(rol))
            {
                if (rol == "Cliente")
                {
                    return Redirect("/Escritorio");
                }
                else
                {
                    return Redirect(rol + "/Escritorio");
                }
            }
            else
            {
                ViewData["layout"] = "Vacio";
                return View("Views/Login/Login.cshtml");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Admin");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            
            /*return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });*/
            return View("Views/Programador/Escritorio");
        }

        [HttpPost]
        public async Task<IActionResult> Admin(string username, string password, string ReturnUrl)
        {
            if(username == null || username == "")
            {

            }
            UsuarioDTO usuarioDTO = _usuarioBL.Login(new UsuarioDTO
            {
                Login = username,
                Password = CreateMD5(password)
            });
            if (usuarioDTO != null)
            {
                var str = JsonConvert.SerializeObject(usuarioDTO);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuarioDTO.FullName),
                    new Claim(ClaimTypes.NameIdentifier, str),
                    new Claim(ClaimTypes.UserData, usuarioDTO.Id.ToString()),
                    new Claim(ClaimTypes.Role, usuarioDTO.Tipo)
                };

                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return Redirect("/"+ usuarioDTO.Tipo +"/Escritorio");
            }
            else {
                ViewData["Error"] = "Usuario incorrecto";
                return View(); }
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
