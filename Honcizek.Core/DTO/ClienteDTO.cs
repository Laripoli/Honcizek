using System;
namespace Honcizek.Core.DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Clave { get; set; }
        public int? LocalidadId { get; set; }
        public int? ProvinciaId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string Tipo { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nifcif { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Cp { get; set; }
        public string Observaciones { get; set; }
        public string FullName
        {
            get
            {
                if (this.Tipo == "Persona")
                    return this.Nombre + " " + this.Apellidos;
                return this.RazonSocial;
            }
        }

        public string Fecha
        {
            get
            {
                return this.FechaRegistro?.ToShortDateString();
            }
        }
        public ClienteDTO()
        {
        }

        public ClienteDTO(string nombre, string password)
        {
            Nombre = nombre;
            Clave = password;
        }
    }
}
