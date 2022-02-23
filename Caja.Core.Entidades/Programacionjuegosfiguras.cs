using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Programacionjuegosfiguras
    {
        public int IdProgramacionJuegoFigura { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int IdPlenoAutomatico { get; set; }
        public double ValorPremio { get; set; }
        public string Estado { get; set; }

        public virtual Plenoautomatico IdPlenoAutomaticoNavigation { get; set; }
        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
    }
}
