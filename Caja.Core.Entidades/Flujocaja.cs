using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Flujocaja
    {
        public int IdFlujoCaja { get; set; }
        public int IdProgramacionJuego { get; set; }
        public double ValorInicial { get; set; }
        public double ValorFinal { get; set; }
        public double ValorInicialBancos { get; set; }
        public double ValorFinalBancos { get; set; }
        public double ValorInicialSocial { get; set; }
        public double ValorFinalSocial { get; set; }
        public string Estado { get; set; }

        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
    }
}
