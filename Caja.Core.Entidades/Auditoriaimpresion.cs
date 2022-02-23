using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Auditoriaimpresion
    {
        public int Id { get; set; }
        public DateTime FechaImpresion { get; set; }
        public int IdJuego { get; set; }
        public string Linea1 { get; set; }
        public string Linea2 { get; set; }
        public string Linea3 { get; set; }
        public bool CodigoBarras { get; set; }
        public string Serie { get; set; }
        public int HojaInicio { get; set; }
        public int NumeroDesde { get; set; }
        public int NumeroHasta { get; set; }
        public int IdUsuarioImpresion { get; set; }
    }
}
