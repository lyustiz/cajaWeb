using System;

namespace Caja.API.DTO
{
    public class ConfiguracionDTO
    {
        public int IdConfiguracion { get; set; }
        public int NumeroJuego { get; set; }
        public int Carton { get; set; }
        public string Serie { get; set; }
        public int Balotas { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? IdUsuario { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public short Reconfigurado { get; set; }
    }
}
