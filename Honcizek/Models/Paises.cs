using System;
using System.Collections.Generic;

namespace Honcizek.Models
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
