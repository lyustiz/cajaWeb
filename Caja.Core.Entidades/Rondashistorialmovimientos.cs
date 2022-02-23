using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Rondashistorialmovimientos
    {
        public int IdHistorialMovimiento { get; set; }
        public int IdFiguraRonda { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaHora { get; set; }

        public virtual Rondasfiguras IdFiguraRondaNavigation { get; set; }
    }
}
