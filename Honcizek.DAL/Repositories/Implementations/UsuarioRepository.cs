using System;
using System.Collections.Generic;
using System.Linq;
using Honcizek.Core.DTO;
using Honcizek.DAL.Models;
using Honcizek.DAL.Repositories.Contracts;

namespace Honcizek.DAL.Repositories.Implementations
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public honcizekContext _context { get; set; }

        public UsuarioRepository(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Autenticación del login
        /// </summary>
        /// <param name="usuarioDTO"></param>
        /// <returns>UsuarioDTO</returns>
        public UsuarioDTO Login(UsuarioDTO usuarioDTO)
        {


            var buscaUsuario = _context.Usuarios.FirstOrDefault(u => u.Login == usuarioDTO.Login && u.Clave == u.Clave);

            if (buscaUsuario == null)
            {
                return null;
            }
            var encontrado = new UsuarioDTO
            {
                Id = buscaUsuario.Id,
                Login = buscaUsuario.Login,
                Password = buscaUsuario.Clave,
                Nombre = buscaUsuario.Nombre,
                Apellidos = buscaUsuario.Apellidos,
                Email = buscaUsuario.Email,
                Tipo = buscaUsuario.Puesto

            };

            return encontrado;
        }

        /// <summary>
        /// Devuelve todos los usuarios
        /// </summary>
        /// <returns>IEnumerable<UsuarioDTO></returns>
        public IEnumerable<UsuarioDTO> Get()
        {
            var usuarios = _context.Usuarios.ToList();

            //Mapeo de Usuario a UsuarioDTO
            List<UsuarioDTO> usuariosdto = new List<UsuarioDTO>();

            foreach (var u in usuarios)
            {
                var usuario = new UsuarioDTO
                {
                    Id = u.Id,
                    Login = u.Login,
                    Password = u.Clave,
                    Nombre = u.Nombre,
                    Apellidos = u.Apellidos,
                    Email = u.Email
                };
                usuariosdto.Add(usuario);
            }

            return usuariosdto;

        }

    }
}