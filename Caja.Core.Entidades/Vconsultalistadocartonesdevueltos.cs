using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Vconsultalistadocartonesdevueltos
    {
        public int NumeroHoja { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int IdProgramacionJuego { get; set; }
        public string Estado { get; set; }
    }
}
