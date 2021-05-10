﻿using System;
using System.Collections.Generic;

namespace Honcizek.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            PartesDeTrabajo = new HashSet<PartesDeTrabajo>();
            ProyectosParticipantes = new HashSet<ProyectosParticipantes>();
            Servicios = new HashSet<Servicios>();
            Suscripciones = new HashSet<Suscripciones>();
            Tareas = new HashSet<Tareas>();
            Tickets = new HashSet<Tickets>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public string Puesto { get; set; }

        public virtual ICollection<PartesDeTrabajo> PartesDeTrabajo { get; set; }
        public virtual ICollection<ProyectosParticipantes> ProyectosParticipantes { get; set; }
        public virtual ICollection<Servicios> Servicios { get; set; }
        public virtual ICollection<Suscripciones> Suscripciones { get; set; }
        public virtual ICollection<Tareas> Tareas { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
