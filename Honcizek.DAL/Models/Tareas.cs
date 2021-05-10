using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class Tareas
    {
        public Tareas()
        {
            TiemposTareas = new HashSet<TiemposTareas>();
        }

        public int Id { get; set; }
        public int TrabajoId { get; set; }
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public int TiempoPrevisto { get; set; }
        public string Descripcion { get; set; }
        public int? HorasPrevistas { get; set; }
        public int? MinutosPrevistos { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual Trabajos Trabajo { get; set; }
        public virtual Usuarios Usuario { get; set; }
        public virtual ICollection<TiemposTareas> TiemposTareas { get; set; }
    }
}
