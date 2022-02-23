using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Vendedorescobrocartones
    {
        public int IdVendedorCobroCarton { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int IdVendedor { get; set; }
        public int TotalCartones { get; set; }
        public int CartonesDevueltos { get; set; }
        public int NumeroHojasEntregadas { get; set; }
        public double PorcentajeComision { get; set; }
        public double TotalVentas { get; set; }
        public int CartonesCortesia { get; set; }
        public double ValorComision { get; set; }
        public double Abonos { get; set; }
        public double TotalPagado { get; set; }
        public double Faltante { get; set; }
        public double TotalRecibido { get; set; }
        public double GastoCortesia { get; set; }
        public double TotalModulos { get; set; }
        public string Estado { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
        public virtual Vendedores IdVendedorNavigation { get; set; }
    }
}
