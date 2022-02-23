using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Porcentajepremios
    {
        public int IdPorcentajePremio { get; set; }
        public int? Premio1Cartones { get; set; }
        public int? Premio1Porcentaje { get; set; }
        public int? Premio2Cartones { get; set; }
        public int? Premio2Porcentaje { get; set; }
        public int? Premio3Cartones { get; set; }
        public int? Premio3Porcentaje { get; set; }
        public int? Premio4Cartones { get; set; }
        public int? Premio4Porcentaje { get; set; }
        public int? Premio5Cartones { get; set; }
        public int? Premio5Porcentaje { get; set; }
        public int? IdUsuario { get; set; }
        public string Estado { get; set; }
        public short? ActivoDescuento { get; set; }

        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
