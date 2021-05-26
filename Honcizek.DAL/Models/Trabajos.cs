using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class Trabajos
    {
        public int Id { get; set; }
        public int ProyectoId { get; set; }
        [Required(ErrorMessage = "Debes introducir un nombre")]
        public string Nombre { get; set; }
        public int AgenteId { get; set; }
        public string Descripcion { get; set; }

        public virtual Usuarios Agente { get; set; }
        public virtual Proyectos Proyecto { get; set; }
    }
}
