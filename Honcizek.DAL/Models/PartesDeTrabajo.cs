using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class PartesDeTrabajo
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int AgenteId { get; set; }
        [Required(ErrorMessage = "Debes introducir un nombre")]
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        [Required(ErrorMessage = "Debes introducir una descripción del trabajo")]
        public string Descripcion { get; set; }
        public int Horas { get; set; }
        public int Minutos { get; set; }

        public virtual Usuarios Agente { get; set; }
        public virtual Tickets Ticket { get; set; }

        public string FRegistro
        {
            get
            {
                return Fecha.ToShortDateString();
            }
        }

        public string Tiempo
        {
            get
            {
                if (Minutos > 0 && Minutos < 60 && Horas <= 0) {
                    return Minutos.ToString() + " minutos";
                }
                else if (Minutos > 0)
                {
                    return Math.Round((decimal)Horas + ((decimal)Minutos / 60),1).ToString() + (Horas == 1 ? " hora" : " horas");
                }
                else
                {
                    return Horas.ToString() + (Horas > 1 ? " horas":" hora");
                }
            }
        }
    }
}
