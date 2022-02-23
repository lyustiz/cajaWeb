using System;

namespace Caja.API.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public string Celular { get; set; }
        public string Token { get; set; }
        public char TipoUsuario { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? Actualizado { get; set; }
    }
}
