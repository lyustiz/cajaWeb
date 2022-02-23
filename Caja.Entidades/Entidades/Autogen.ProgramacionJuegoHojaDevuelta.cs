using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class ProgramacionJuegoHojaDevuelta
	{
		private int mIdProgramacionJuegoHojaDevuelta;

		private int mIdProgramacionJuego;

		private int mNumeroHoja;

		private DateTime mFechaHora;

		private char mEstado;

		public ProgramacionJuegoHojaDevuelta()
		{
		}

		public int IdProgramacionJuegoHojaDevuelta
		{
			get { return mIdProgramacionJuegoHojaDevuelta; }
			set { mIdProgramacionJuegoHojaDevuelta = value; }
		}

		public int IdProgramacionJuego
		{
			get { return mIdProgramacionJuego; }
			set { mIdProgramacionJuego = value; }
		}

		public int NumeroHoja
		{
			get { return mNumeroHoja; }
			set { mNumeroHoja = value; }
		}

		public DateTime FechaHora
		{
			get { return mFechaHora; }
			set { mFechaHora = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}
	}
}
