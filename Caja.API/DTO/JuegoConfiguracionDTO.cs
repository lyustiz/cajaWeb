using System;
using System.Collections.Generic;

namespace Caja.API.DTO
{
    public class JuegoConfiguracionDTO
    {
        public int IdJuego { get; set; }
        public string TipoJuego { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public short? IdEmpresa { get; set; }
        public string Terminado { get; set; }
        public int ModuloCartones { get; set; }
        public string Moneda { get; set; }
        public double ValorModulo { get; set; }
        public double ValorCarton { get; set; }
        public DateTime? Actualizado { get; set; }
        public double TotalCartones { get; set; }
        public List<FiguraDTO> Premios { get; set; }
        public ConfiguracionDTO Configuracion { get; set; }
        public DateTime? CurrentTime { get; set; }
    }
}
