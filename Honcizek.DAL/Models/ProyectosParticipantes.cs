using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class ProyectosParticipantes
    {
        public int Id { get; set; }
        public int ProyectoId { get; set; }
        public int UsuarioId { get; set; }

        public virtual Proyectos Proyecto { get; set; }
        public virtual Usuarios Usuario { get; set; }
    }
}
