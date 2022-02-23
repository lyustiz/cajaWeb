using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Rondas
    {
        public Rondas()
        {
            Rondasfiguras = new HashSet<Rondasfiguras>();
        }

        public int IdRonda { get; set; }
        public int IdJuego { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public string Estado { get; set; }
        public TimeSpan? Duracion { get; set; }
        public int IdUsuario { get; set; }

        public virtual Juegos IdJuegoNavigation { get; set; }
        public virtual ICollection<Rondasfiguras> Rondasfiguras { get; set; }
    }
}
