using System;

namespace Caja.API.DTO
{
    public class ProgramacionJuegosDTO
    {
        public int IdProgramacionJuego { get; set; }
        public int? IdJuego { get; set; }
        public DateTime FechaProgramada { get; set; }
        public DateTime? FechaCierre { get; set; }
        public double ValorCarton { get; set; }
        public double TotalCartones { get; set; }
        public double ValorModulo { get; set; }
        public double TotalModulos { get; set; }
        public double TotalPremios { get; set; }
        public int IdSerie { get; set; }
        public int CartonInicial { get; set; }
        public int CartonFinal { get; set; }
        public int HojaInicial { get; set; }
        public int HojaFinal { get; set; }
        public double ResultadoFinal { get; set; }
        public string Estado { get; set; }
    }
}
