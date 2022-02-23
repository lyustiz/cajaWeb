using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Juegosbalotasuerte
    {
        public int IdJuego { get; set; }
        public int IdModoPago { get; set; }
        public double Valor { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuario { get; set; }
        public int Balotas { get; set; }
        public int BalotaFinal { get; set; }
        public int BalotaSuerte { get; set; }
        public int IdEstadoBalotaSuerte { get; set; }
    }
}
