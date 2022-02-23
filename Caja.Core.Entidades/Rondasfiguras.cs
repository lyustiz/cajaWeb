using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Rondasfiguras
    {
        public Rondasfiguras()
        {
            Rondashistorialmovimientos = new HashSet<Rondashistorialmovimientos>();
        }

        public int IdFiguraRonda { get; set; }
        public int IdRonda { get; set; }
        public int IdPlenoAutomatico { get; set; }
        public double ValorPremio { get; set; }
        public int IdEstadoRondaFigura { get; set; }
        public int CantidadGanadores { get; set; }
        public bool? MarcadaVendida { get; set; }
        public bool? MarcadaNoVendida { get; set; }
        public int IdJuego { get; set; }
        public int IdUsuario { get; set; }
        public bool? EsSencillo { get; set; }
        public string TipoFigura { get; set; }
        public double ValorFigura { get; set; }
        public double ValorAcumulado { get; set; }

        public virtual Rondas IdRondaNavigation { get; set; }
        public virtual ICollection<Rondashistorialmovimientos> Rondashistorialmovimientos { get; set; }
    }
}
