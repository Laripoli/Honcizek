using System;
using System.Collections.Generic;
using System.Linq;
using Honcizek.Core.DTO;
using Honcizek.DAL.Models;
using Honcizek.DAL.Repositories.Contracts;

namespace Honcizek.DAL.Repositories.Implementations
{
    public class ClienteRepository : IClienteRepository
    {
        public honcizekContext _context { get; set; }

        public ClienteRepository(honcizekContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Autenticación del login
        /// </summary>
        /// <param name="clienteDTO"></param>
        /// <returns>ClienteDTO</returns>
        public ClienteDTO Login(ClienteDTO clienteDTO)
        {


            var buscaCliente = _context.Clientes.FirstOrDefault(u => u.Login == clienteDTO.Login && u.Clave == u.Clave);

            if (buscaCliente == null)
            {
                return null;
            }
            var encontrado = new ClienteDTO
            {
                Id = buscaCliente.Id,
                Login = buscaCliente.Login,
                Clave = buscaCliente.Clave,
                LocalidadId = buscaCliente.LocalidadId,
                ProvinciaId = buscaCliente.ProvinciaId,
                FechaRegistro = buscaCliente.FechaRegistro,
                Tipo = buscaCliente.Tipo,
                RazonSocial = buscaCliente.RazonSocial,
                Nombre = buscaCliente.Nombre,
                Apellidos = buscaCliente.Apellidos,
                Nifcif = buscaCliente.Nifcif,
                Telefono = buscaCliente.Telefono,
                Movil = buscaCliente.Movil,
                Email = buscaCliente.Email,
                Direccion = buscaCliente.Direccion,
                Cp = buscaCliente.Cp,
                Observaciones = buscaCliente.Observaciones

            };

            return encontrado;
        }

        /// <summary>
        /// Devuelve todos los clientes
        /// </summary>
        /// <returns>IEnumerable<ClienteDTO></returns>
        public IEnumerable<ClienteDTO> Get()
        {
            var clientes = _context.Clientes.ToList();

            //Mapeo de Cliente a ClienteDTO
            List<ClienteDTO> clientesdto = new List<ClienteDTO>();

            foreach (var c in clientes)
            {
                var cliente = new ClienteDTO
                {
                    Id = c.Id,
                    Login = c.Login,
                    Clave = c.Clave,
                    LocalidadId = c.LocalidadId,
                    ProvinciaId = c.ProvinciaId,
                    FechaRegistro = c.FechaRegistro,
                    Tipo = c.Tipo,
                    RazonSocial = c.RazonSocial,
                    Nombre = c.Nombre,
                    Apellidos = c.Apellidos,
                    Nifcif = c.Nifcif,
                    Telefono = c.Telefono,
                    Movil = c.Movil,
                    Email = c.Email,
                    Direccion = c.Direccion,
                    Cp = c.Cp,
                    Observaciones = c.Observaciones
                };
                clientesdto.Add(cliente);
            }

            return clientesdto;

        }

    }
}