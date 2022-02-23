using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Juegosbalotasfinales
    {
        public int? IdJuego { get; set; }
        public int Balota { get; set; }
        public int ModoPago { get; set; }
        public double Valor { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuario { get; set; }
    }
}
