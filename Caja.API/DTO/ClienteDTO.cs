using System;

namespace Caja.API.DTO
{
    public class ClienteDTO
    {
        public int IdCliente { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Documento { get; set; }
        public string Barrio { get; set; }
        public string Estado { get; set; }
        public DateTime? Actualizado { get; set; }
    }
}
