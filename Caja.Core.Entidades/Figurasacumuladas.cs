using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Figurasacumuladas
    {
        public int IdFiguraAcumulada { get; set; }
        public int IdJuego { get; set; }
        public int IdRonda { get; set; }
        public int IdPlenoAutomatico { get; set; }
        public double Valor { get; set; }
        public string Estado { get; set; }
    }
}
