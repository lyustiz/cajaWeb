using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Ingresosprogramacionjuegos
    {
        public int IdIngresoJuego { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int IdUsuario { get; set; }
        public int IdConceptoIngreso { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public string Estado { get; set; }

        public virtual Conceptoingresos IdConceptoIngresoNavigation { get; set; }
        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
