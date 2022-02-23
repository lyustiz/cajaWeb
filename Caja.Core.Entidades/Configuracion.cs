using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Configuracion
    {
        public int IdConfiguracion { get; set; }
        public int NumeroJuego { get; set; }
        public int Carton { get; set; }
        public string Serie { get; set; }
        public int Balotas { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? IdUsuario { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public short Reconfigurado { get; set; }

        public virtual Juegos IdJuegoNavigation { get; set; }
    }
}
