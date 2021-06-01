using System;
namespace Honcizek.Core.DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email{ get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Tipo { get; set; }

        public string FullName
        {
            get
            {
                return Nombre + " " + Apellidos;
            }
        }
        public UsuarioDTO()
        {
        }

        public UsuarioDTO(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }
    }
}
