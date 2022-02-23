using System;

namespace Caja.Entidades.Vistas
{
    public sealed class VistaGastosProgramacionJuego
    {
        public int IdGastoJuego { get; set; }

        public int IdProgramacionJuego { get; set; }

        public DateTime FechaHora { get; set; }

        public int IdUsuario { get; set; }

        public int IdConceptoGasto { get; set; }

        public string Descripcion { get; set; }

        public double Valor { get; set; }

        public string Socio { get; set; }

        public char Estado { get; set; }

        public string NombreUsuario { get; set; }

        public string Concepto { get; set; }
    }
}
