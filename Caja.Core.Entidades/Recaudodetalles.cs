using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Recaudodetalles
    {
        public int IdRecaudoDetalle { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int IdUsuario { get; set; }
        public int IdDefinicionMoneda { get; set; }
        public int Cantidad { get; set; }
        public double TotalRecaudo { get; set; }
        public string Estado { get; set; }

        public virtual Definicionmonedas IdDefinicionMonedaNavigation { get; set; }
        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
