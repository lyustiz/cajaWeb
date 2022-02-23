using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Auditoriahistoria
    {
        public int IdAuditoriaHistoria { get; set; }
        public int? IdUsuario { get; set; }
        public string Estado { get; set; }
        public int? Accion { get; set; }
        public string ValorAnterior { get; set; }
        public string ValorNuevo { get; set; }
        public int? IdJuego { get; set; }
    }
}
