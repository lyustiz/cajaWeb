using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Rondasseries
    {
        public int IdSerieRonda { get; set; }
        public int IdRonda { get; set; }
        public string Simbolo { get; set; }
        public int CartonInicial { get; set; }
        public int CartonFinal { get; set; }
        public string Modulo { get; set; }
        public string Cliente { get; set; }
        public string Celular { get; set; }
        public string Barrio { get; set; }
    }
}
