using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Vrondasseries
    {
        public int IdRonda { get; set; }
        public string Simbolo { get; set; }
        public int CartonInicial { get; set; }
        public int CartonFinal { get; set; }
        public string Tabla { get; set; }
    }
}
