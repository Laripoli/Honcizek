using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class Localidades
    {
        public Localidades()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int Id { get; set; }
        public int? ProvinciaId { get; set; }
        public string Nombre { get; set; }

        public virtual Provincias Provincia { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
