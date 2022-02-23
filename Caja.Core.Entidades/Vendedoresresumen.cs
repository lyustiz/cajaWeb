using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Vendedoresresumen
    {
        public int IdVendedorResumen { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int IdVendedor { get; set; }
        public int TotalCartones { get; set; }
        public int CartonesCortesia { get; set; }
        public double ValorTotal { get; set; }
        public double PagoAnticipado { get; set; }
        public double ValorPendiente { get; set; }
        public int CartonesDevueltos { get; set; }
        public int NumeroHojasDevueltas { get; set; }
        public double PorcentajeComision { get; set; }
        public byte Cobrado { get; set; }
        public double Faltante { get; set; }
        public double GastoCortesia { get; set; }
        public int CantidadModulos { get; set; }
        public double ValorModulos { get; set; }
        public string Estado { get; set; }

        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
        public virtual Vendedores IdVendedorNavigation { get; set; }
    }
}
