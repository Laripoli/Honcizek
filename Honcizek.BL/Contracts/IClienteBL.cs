using Honcizek.Core.DTO;
using System.Collections.Generic;

namespace Honcizek.BL.Contracts
{
    public interface IClienteBL
    {
        ClienteDTO Login(ClienteDTO clienteDTO);
        IEnumerable<ClienteDTO> Get();
    }
}
