using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Programaciondevolucioncodigobarras
    {
        public int IdDevolucionCodigoBarra { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int IdVendedor { get; set; }
        public string HojaCarton { get; set; }

        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
        public virtual Vendedores IdVendedorNavigation { get; set; }
    }
}
