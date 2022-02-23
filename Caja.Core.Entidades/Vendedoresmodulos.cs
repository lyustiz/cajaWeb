using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Vendedoresmodulos
    {
        public int IdVendedorModulo { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int IdVendedor { get; set; }
        public int IdClienteModulo { get; set; }
        public string Estado { get; set; }

        public virtual ClienteModulo IdClienteModuloNavigation { get; set; }
        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
        public virtual Vendedores IdVendedorNavigation { get; set; }
    }
}
