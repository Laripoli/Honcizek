using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class Tickets
    {
        public Tickets()
        {
            PartesDeTrabajo = new HashSet<PartesDeTrabajo>();
        }

        public int Id { get; set; }
        public int SuscripcionId { get; set; }
        public int ClienteId { get; set; }
        public int AgenteId { get; set; }
        [Required(ErrorMessage = "Debes introducir un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debes introducir una descripción")]
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string HoraRegistro { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public string HoraFinalizacion { get; set; }

        public virtual Usuarios Agente { get; set; }
        public virtual Clientes Cliente { get; set; }
        public virtual Suscripciones Suscripcion { get; set; }
        public virtual ICollection<PartesDeTrabajo> PartesDeTrabajo { get; set; }

        public string FRegistro
        {
            get
            {
                return this.FechaRegistro.ToShortDateString();
            }
        }
        public string FFin
        {
            get
            {
                return this.FechaFinalizacion?.ToShortDateString();
            }
        }
    }
}
