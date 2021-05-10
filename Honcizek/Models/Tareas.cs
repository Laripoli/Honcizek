using System;
using System.Collections.Generic;

namespace Honcizek.Models
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
