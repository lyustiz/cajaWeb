using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Programacionjuegoshojasdevueltas
    {
        public int IdProgramacionJuegoHojaDevuelta { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int NumeroHoja { get; set; }
        public string Estado { get; set; }

        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
    }
}
