using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class Provincias
    {
        public Provincias()
        {
            Clientes = new HashSet<Clientes>();
            Localidades = new HashSet<Localidades>();
        }

        public int Id { get; set; }
        public int PaisId { get; set; }
        public string Nombre { get; set; }
        public string Comunidad { get; set; }
        public string Normalizado { get; set; }

        public virtual Paises Pais { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Localidades> Localidades { get; set; }
    }
}
