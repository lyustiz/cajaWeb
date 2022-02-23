using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Serieimprimirlinea
    {
        public string Linea1 { get; set; }
        public string Linea2 { get; set; }
        public string Linea3 { get; set; }
        public bool CodigoBarras { get; set; }
        public int? NumeroJuego { get; set; }
        public string Serie { get; set; }
    }
}
