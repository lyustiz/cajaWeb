using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Recaudofaltantes
    {
        public int IdRecaudoFaltante { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int IdUsuario { get; set; }
        public int IdVendedor { get; set; }
        public string Estado { get; set; }
        public double ValorRecibido { get; set; }

        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
        public virtual Vendedores IdVendedorNavigation { get; set; }
    }
}
