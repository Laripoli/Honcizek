using System;
using System.Collections.Generic;

namespace Honcizek.Models
{
    public partial class TiemposTareas
    {
        public int Id { get; set; }
        public int TareaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Tiempo { get; set; }

        public virtual Tareas Tarea { get; set; }
    }
}
