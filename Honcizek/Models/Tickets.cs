﻿using System;
using System.Collections.Generic;

namespace Honcizek.Models
{
    public partial class Tickets
    {
        public Tickets()
        {
            PartesDeTrabajo = new HashSet<PartesDeTrabajo>();
        }

        public int Id { get; set; }
        public int SuscripcionId { get; set; }
        public int AgenteId { get; set; }
        public int ClienteId { get; set; }
        public string ContactoNombre { get; set; }
        public string Nombre { get; set; }
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
    }
}