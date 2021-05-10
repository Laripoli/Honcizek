﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            Proyectos = new HashSet<Proyectos>();
            Suscripciones = new HashSet<Suscripciones>();
            Tareas = new HashSet<Tareas>();
            Tickets = new HashSet<Tickets>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Clave { get; set; }
        public int? LocalidadId { get; set; }
        public int? ProvinciaId { get; set; }
        public int? PaisId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Tipo { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nifcif { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Cp { get; set; }
        public string Observaciones { get; set; }

        public virtual Localidades Localidad { get; set; }
        public virtual Paises Pais { get; set; }
        public virtual Provincias Provincia { get; set; }
        public virtual ICollection<Proyectos> Proyectos { get; set; }
        public virtual ICollection<Suscripciones> Suscripciones { get; set; }
        public virtual ICollection<Tareas> Tareas { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}