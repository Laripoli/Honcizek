using System;
using System.Collections.Generic;

namespace Honcizek.Models
{
    public partial class Servicios
    {
        public Servicios()
        {
            Suscripciones = new HashSet<Suscripciones>();
        }

        public int Id { get; set; }
        public string TipoId { get; set; }
        public int AgenteId { get; set; }
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

        public virtual Usuarios Agente { get; set; }
        public virtual ICollection<Suscripciones> Suscripciones { get; set; }
    }
}
