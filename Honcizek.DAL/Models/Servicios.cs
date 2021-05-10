using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class Servicios
    {
        public Servicios()
        {
            Suscripciones = new HashSet<Suscripciones>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string AvisoCaducidad { get; set; }
        public decimal? PrecioAlta { get; set; }
        public decimal? PrecioPeriodo { get; set; }
        public decimal? PrecioConsumoNivel1 { get; set; }
        public decimal? PrecioConsumoNivel2 { get; set; }
        public decimal? PrecioConsumoNivel3 { get; set; }
        public int? HorasContratadas { get; set; }
        public string Periodicidad { get; set; }

        public virtual Usuarios Usuario { get; set; }
        public virtual ICollection<Suscripciones> Suscripciones { get; set; }
    }
}
