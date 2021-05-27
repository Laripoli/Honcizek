using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            PartesDeTrabajo = new HashSet<PartesDeTrabajo>();
            ProyectosParticipantes = new HashSet<ProyectosParticipantes>();
            Suscripciones = new HashSet<Suscripciones>();
            Tickets = new HashSet<Tickets>();
            Trabajos = new HashSet<Trabajos>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Debes introducir un nombre de usuario")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Debes introducir un nombre")]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Debes introducir una clave")]
        public string Clave { get; set; }
        public string Email { get; set; }
        public string Puesto { get; set; }

        public virtual ICollection<PartesDeTrabajo> PartesDeTrabajo { get; set; }
        public virtual ICollection<ProyectosParticipantes> ProyectosParticipantes { get; set; }
        public virtual ICollection<Suscripciones> Suscripciones { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }
        public virtual ICollection<Trabajos> Trabajos { get; set; }

        public string FullName
        {
            get
            {
                return Nombre + " " + Apellidos;
            }
        }
    }
}
