using System;
using System.Collections.Generic;

namespace Honcizek.Models
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
