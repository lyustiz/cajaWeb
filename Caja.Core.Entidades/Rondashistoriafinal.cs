using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Rondashistoriafinal
    {
        public int Idhistoriafinal { get; set; }
        public int? IdRonda { get; set; }
        public int? Balota { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdJuego { get; set; }
        public int IdUsuario { get; set; }
    }
}
