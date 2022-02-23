using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Vvendedoresentregacartones
    {
        public int? IdVendedor { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string IdProgramacionJuego { get; set; }
        public string SumaDeNumeroHoja { get; set; }
    }
}
