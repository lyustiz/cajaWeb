using System;

namespace Caja.Core.Entidades
{
    public class Cartones
    {
        public int IdCarton { get; set; }
        public int IdJuego { get; set; }
        public int IdSerie { get; set; }
        public int Numero { get; set; }
        public int? IdModulo { get; set; }
        public int? NumeroModulo { get; set; }
        public int? Idvendedor { get; set; }
        public int? IdCliente { get; set; }
        public string Estado { get; set; }
        public DateTime? Actualizado { get; set; }

        public virtual Juegos IdJuegoNavigation { get; set; }
    }
}
