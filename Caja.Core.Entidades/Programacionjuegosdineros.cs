using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Programacionjuegosdineros
    {
        public int IdProgramacionJuegoDinero { get; set; }
        public int IdProgramacionJuego { get; set; }
        public double TotalCartones { get; set; }
        public double AsistenciaSocial { get; set; }
        public double TotalVentas { get; set; }
        public double TotalCuentasCobrar { get; set; }
        public double TotalRecaudoJuego { get; set; }
        public double DineroBanco { get; set; }
        public double Efectivo { get; set; }
        public string CerradoBanco { get; set; }
        public string Estado { get; set; }

        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
    }
}
