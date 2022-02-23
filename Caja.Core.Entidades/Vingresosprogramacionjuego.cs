using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Vingresosprogramacionjuego
    {
        public int IdIngresoJuego { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int IdUsuario { get; set; }
        public int IdConceptoIngreso { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public string Estado { get; set; }
        public string NombreUsuario { get; set; }
        public string Concepto { get; set; }
    }
}
