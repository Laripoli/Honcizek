using System;
using System.Collections.Generic;

namespace Honcizek.Models
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
