using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Vendedorescuentascobrar
    {
        public int IdVendedorCuentaCobrar { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int IdVendedor { get; set; }
        public double Valor { get; set; }
        public DateTime? FechaPago { get; set; }
        public int? IdProgramacionJuegoPago { get; set; }
        public string Estado { get; set; }

        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
        public virtual Vendedores IdVendedorNavigation { get; set; }
    }
}
