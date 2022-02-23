using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja.Entidades.Vistas
{
    public sealed class VistaGastoGeneral
    {
        public int IdGastoGeneral { get; set; }

        public DateTime FechaHora { get; set; }

        public int IdUsuario { get; set; }

        public int IdConceptoGasto { get; set; }

        public string Descripcion { get; set; }

        public double Valor { get; set; }

        public string Socio { get; set; }

        public DateTime FechaRegistro { get; set; }

        public byte Mes { get; set; }

        public short Anio { get; set; }

        public char OrigenPago { get; set; }

        public char Estado { get; set; }

        public string NombreUsuario { get; set; }

        public string Concepto { get; set; }        
    }
}
