using System;
using System.Collections.Generic;
using Honcizek.Core.DTO;

namespace Honcizek.DAL.Repositories.Contracts
{
    public interface IClienteRepository
    {
        ClienteDTO Login(ClienteDTO clienteDTO);
        IEnumerable<ClienteDTO> Get();
    }
}