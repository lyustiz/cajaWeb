using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class AuditoriaHistoria
	{
		private int mIdAuditoriaHistoria;

		private DateTime mFechaHora;

		private int mIdUsuario;

		private char mEstado;

		private int mAcccion;

		private string mValorAnterior;

		private string mValorNuevo;

		private int mIdJuego;
				
		public AuditoriaHistoria()
		{
		}

        public int IdAuditoriaHistoria { get => mIdAuditoriaHistoria; set => mIdAuditoriaHistoria = value; }
        public DateTime FechaHora { get => mFechaHora; set => mFechaHora = value; }
        public int IdUsuario { get => mIdUsuario; set => mIdUsuario = value; }
        public char Estado { get => mEstado; set => mEstado = value; }
        public int Acccion { get => mAcccion; set => mAcccion = value; }
        public string ValorAnterior { get => mValorAnterior; set => mValorAnterior = value; }
        public string ValorNuevo { get => mValorNuevo; set => mValorNuevo = value; }
        public int IdJuego { get => mIdJuego; set => mIdJuego = value; }
    }
}
