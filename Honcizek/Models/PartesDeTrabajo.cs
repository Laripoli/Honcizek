using System;
using System.Collections.Generic;

namespace Honcizek.Models
{
    public partial class PartesDeTrabajo
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int AgenteId { get; set; }
        public string Nombre { get; set; }
        public string ContactoNombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Tiempo { get; set; }

        public virtual Usuarios Agente { get; set; }
        public virtual Tickets Ticket { get; set; }
    }
}
