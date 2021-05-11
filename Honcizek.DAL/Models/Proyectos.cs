using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class Proyectos
    {
        public Proyectos()
        {
            ProyectosParticipantes = new HashSet<ProyectosParticipantes>();
            Suscripciones = new HashSet<Suscripciones>();
            Trabajos = new HashSet<Trabajos>();
        }

        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionDesarrollo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFinPrevista { get; set; }
        public DateTime? FechaFinReal { get; set; }
        public int? HorasInternasPrevistas { get; set; }
        public string Estado { get; set; }
        public string Fase { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual ICollection<ProyectosParticipantes> ProyectosParticipantes { get; set; }
        public virtual ICollection<Suscripciones> Suscripciones { get; set; }
        public virtual ICollection<Trabajos> Trabajos { get; set; }
    }
}
