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

    public class LoginCController : Controller
    {
        /*private readonly ILogger<LoginController> _logger;*/
        public IClienteBL _clienteBL { get; set; }

        public LoginCController(IClienteBL clienteBL)
        {
            /*_logger = logger;*/
            _clienteBL = clienteBL;
        }

        public IActionResult Login()
        {
            ViewData["layout"] = "Vacio";
            return View("Views/LoginC/Login.cshtml");
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
            if (username == null || username == "")
            {

            }
            ClienteDTO clienteDTO = _clienteBL.Login(new ClienteDTO
            {
                Login = username,
                Clave = CreateMD5(password)
            });
            if (clienteDTO != null)
            {
                var str = JsonConvert.SerializeObject(clienteDTO);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, clienteDTO.FullName),
                    new Claim(ClaimTypes.NameIdentifier, str),
                    new Claim(ClaimTypes.UserData, clienteDTO.Id.ToString()),
                    new Claim(ClaimTypes.Role, "Cliente")
                };

                var claimsIdentity = new ClaimsIdentity(claims, "Login");


                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return Redirect("/Escritorio");
            }
            else
            {
                ViewData["Error"] = "Cliente incorrecto";
                return View();
            }
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
