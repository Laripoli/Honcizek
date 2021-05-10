using System;
using System.Collections.Generic;

namespace Honcizek.Models
{
    public partial class Suscripciones
    {
        public Suscripciones()
        {
            Tickets = new HashSet<Tickets>();
        }

        public int Id { get; set; }
        public int ServicioId { get; set; }
        public int ClienteId { get; set; }
        public int? ProyectoId { get; set; }
        public int AgenteId { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int? HorasContratadas { get; set; }
        public string AvisoCaducidad { get; set; }
        public int? ProximidadCaducidad { get; set; }
        public int? Renovacion { get; set; }
        public int? RenovacionId { get; set; }
        public int? Pendiente { get; set; }
        public int? Caducada { get; set; }
        public decimal? PrecioAlta { get; set; }
        public decimal? PrecioPeriodo { get; set; }
        public decimal? PrecioConsumoNivel1 { get; set; }
        public decimal? PrecioConsumoNivel2 { get; set; }
        public decimal? PrecioConsumoNivel3 { get; set; }
        public string Periodicidad { get; set; }
        public string Observaciones { get; set; }

        public virtual Usuarios Agente { get; set; }
        public virtual Clientes Cliente { get; set; }
        public virtual Proyectos Proyecto { get; set; }
        public virtual Servicios Servicio { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
