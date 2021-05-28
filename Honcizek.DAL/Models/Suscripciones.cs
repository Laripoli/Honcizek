using Honcizek.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class Suscripciones
    {
        public Suscripciones()
        {
            Tickets = new HashSet<Tickets>();
        }

        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Debes introducir un nombre")]
        public string Nombre { get; set; }
        public int? ProyectoId { get; set; }
        public int AgenteId { get; set; }
        [DisplayName("Fecha inicio")]
        public DateTime FechaDesde { get; set; }
        [DisplayName("Fecha finalización")]
        public DateTime? FechaHasta { get; set; }
        public int Renovacion { get; set; }
        public decimal? PrecioAlta { get; set; }
        public decimal? PrecioPeriodo { get; set; }
        public string Periodicidad { get; set; }
        public string Observaciones { get; set; }

        public virtual Usuarios Agente { get; set; }
        public virtual Clientes Cliente { get; set; }
        public virtual Proyectos Proyecto { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }

        public string FDesde
        {
            get
            {
                return this.FechaDesde.ToShortDateString();
            }
        }

        public string FHasta
        {
            get
            {
                return this.FechaHasta?.ToShortDateString();
            }
        }
    }
}
