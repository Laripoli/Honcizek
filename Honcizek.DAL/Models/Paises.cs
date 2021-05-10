using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class Paises
    {
        public Paises()
        {
            Clientes = new HashSet<Clientes>();
            Provincias = new HashSet<Provincias>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Iso { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Provincias> Provincias { get; set; }
    }
}
