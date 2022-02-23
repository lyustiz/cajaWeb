using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Nominadescuentos
    {
        public int IdNominaDescuento { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int IdUsuario { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public string Concepto { get; set; }
        public double Valor { get; set; }
        public string Cobrado { get; set; }
        public string Estado { get; set; }

        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
