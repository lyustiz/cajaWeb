using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Rondashistoriaconsulta
    {
        public int IdHistoriaConsulta { get; set; }
        public int Carton { get; set; }
        public string Serie { get; set; }
        public double? Premio { get; set; }
        public int EstadoConsulta { get; set; }
        public int Balotas { get; set; }
        public int IdJuego { get; set; }
        public int IdRonda { get; set; }
        public int? IdFiguraRonda { get; set; }
        public bool? CantoGanador { get; set; }
        public bool Automatico { get; set; }
        public int BalotaFinal { get; set; }
        public double PremioBalotaFinal { get; set; }
        public double PremioBalotaSuerte { get; set; }
        public int IdUsuario { get; set; }
        public string Modulo { get; set; }
        public string Cliente { get; set; }
        public string Celular { get; set; }
        public string Barrio { get; set; }
        public bool? EsSencillo { get; set; }
    }
}
