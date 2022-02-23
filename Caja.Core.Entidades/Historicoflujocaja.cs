using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Historicoflujocaja
    {
        public int IdHistoricoFlujoCaja { get; set; }
        public int IdUsuario { get; set; }
        public byte? Mes { get; set; }
        public short? Anio { get; set; }
        public string OrigenPago { get; set; }
        public double Valor { get; set; }
        public string Accion { get; set; }
        public string Estado { get; set; }

        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
