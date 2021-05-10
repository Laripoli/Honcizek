using System;
using System.Collections.Generic;

namespace Honcizek.Models
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
