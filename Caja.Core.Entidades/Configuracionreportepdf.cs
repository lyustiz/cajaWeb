using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Configuracionreportepdf
    {
        public int IdConfiguracionReportePdf { get; set; }
        public int CartonesPorHoja { get; set; }
        public string Nombre { get; set; }
        public string NombreArchivoRpt { get; set; }
        public short Habilitado { get; set; }
    }
}
