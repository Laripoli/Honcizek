using System;
using System.Collections.Generic;

namespace Honcizek.Models
{
    public partial class Trabajos
    {
        public Trabajos()
        {
            Tareas = new HashSet<Tareas>();
        }

        public int Id { get; set; }
        public int ProyectoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual Proyectos Proyecto { get; set; }
        public virtual ICollection<Tareas> Tareas { get; set; }
    }
}
