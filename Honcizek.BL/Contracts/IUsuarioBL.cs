using Honcizek.Core.DTO;
using System.Collections.Generic;

namespace Honcizek.BL.Contracts
{
    public interface IUsuarioBL
    {
        UsuarioDTO Login(UsuarioDTO usuarioDTO);
        IEnumerable<UsuarioDTO> Get();
    }
}
