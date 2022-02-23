using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Parametrosgenerales
    {
        public int IdParametrosGenerales { get; set; }
        public short? IdEmpresa { get; set; }
        public string Referencia { get; set; }
        public string Descripcion { get; set; }
        public string Valor { get; set; }
    }
}
