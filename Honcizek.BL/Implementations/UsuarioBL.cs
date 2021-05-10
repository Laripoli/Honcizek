using System;
using System.Collections.Generic;
using Honcizek.BL.Contracts;
using Honcizek.Core.DTO;
using Honcizek.DAL.Repositories.Contracts;

namespace Honcizek.BL.Implementations
{
    public class UsuarioBL : IUsuarioBL
    {
        public IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioBL(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public UsuarioDTO Login(UsuarioDTO usuarioDTO)
        {
            return _usuarioRepository.Login(usuarioDTO);
        }

          public IEnumerable<UsuarioDTO> Get()
        {
            return _usuarioRepository.Get();
        }
    }
}
