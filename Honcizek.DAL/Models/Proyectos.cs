using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        public int? ClienteId { get; set; }
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Debes introducir un nombre de proyecto")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionDesarrollo { get; set; }
        public DateTime FechaRegistro { get; set; }
        [DisplayName("Fecha de inicio")]
        public DateTime? FechaInicio { get; set; }
        [DisplayName("Fecha final prevista")]
        public DateTime? FechaFinPrevista { get; set; }
        [DisplayName("Fecha final real")]
        public DateTime? FechaFinReal { get; set; }
        [DisplayName("Horas previstas")]
        public int? HorasInternasPrevistas { get; set; }
        public string Estado { get; set; }
        [Required(ErrorMessage = "Debes seleccionar una fase del proyecto")]
        public string Fase { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual ICollection<ProyectosParticipantes> ProyectosParticipantes { get; set; }
        public virtual ICollection<Suscripciones> Suscripciones { get; set; }
        public virtual ICollection<Trabajos> Trabajos { get; set; }

        public string FRegistro
        {
            get
            {
                return this.FechaRegistro.ToShortDateString();
            }
        }
        public string Finicio
        {
            get
            {
                return this.FechaInicio?.ToShortDateString();
            }
        }
        public string FFin
        {
            get
            {
                return this.FechaFinReal?.ToShortDateString();
            }
        }
        public string FFinPrevista
        {
            get
            {
                return this.FechaFinPrevista?.ToShortDateString();
            }
        }

    }
}