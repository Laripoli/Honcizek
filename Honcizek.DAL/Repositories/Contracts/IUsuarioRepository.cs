﻿using System;
using System.Collections.Generic;
using Honcizek.Core.DTO;

namespace Honcizek.DAL.Repositories.Contracts
{
    public interface IUsuarioRepository
    {
        UsuarioDTO Login(UsuarioDTO usuarioDTO);
        IEnumerable<UsuarioDTO> Get();
    }
}