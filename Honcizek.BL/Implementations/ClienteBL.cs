using System;
using System.Collections.Generic;
using Honcizek.BL.Contracts;
using Honcizek.Core.DTO;
using Honcizek.DAL.Repositories.Contracts;

namespace Honcizek.BL.Implementations
{
    public class ClienteBL : IClienteBL
    {
        public IClienteRepository _clienteRepository { get; set; }

        public ClienteBL(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public ClienteDTO Login(ClienteDTO clienteDTO)
        {
            return _clienteRepository.Login(clienteDTO);
        }

        public IEnumerable<ClienteDTO> Get()
        {
            return _clienteRepository.Get();
        }
    }
}
