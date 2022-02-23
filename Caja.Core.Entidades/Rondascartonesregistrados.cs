using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Rondascartonesregistrados
    {
        public int IdCartonesRegistrados { get; set; }
        public int? IdRonda { get; set; }
        public string Estado { get; set; }
        public int? IdLisTablas { get; set; }
        public int? NumeroCartonInicial { get; set; }
        public int? NumeroCartonFinal { get; set; }
    }
}
