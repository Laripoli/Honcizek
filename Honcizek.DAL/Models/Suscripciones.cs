using System;
using System.Collections.Generic;

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
        public string Nombre { get; set; }
        public int? ProyectoId { get; set; }
        public int AgenteId { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int? Renovacion { get; set; }
        public decimal? PrecioAlta { get; set; }
        public decimal? PrecioPeriodo { get; set; }
        public string Periodicidad { get; set; }
        public string Observaciones { get; set; }

        public virtual Usuarios Agente { get; set; }
        public virtual Clientes Cliente { get; set; }
        public virtual Proyectos Proyecto { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
