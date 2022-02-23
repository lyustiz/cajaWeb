using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class ProgramacionDevolucionCodigoBarra
	{
		private int mIdDevolucionCodigoBarra;

		private int mIdProgramacionJuego;

		private int mIdVendedor;

		private string mHojaCarton;

		private DateTime mFechaHora;

		public ProgramacionDevolucionCodigoBarra()
		{
		}

		public int IdDevolucionCodigoBarra
		{
			get { return mIdDevolucionCodigoBarra; }
			set { mIdDevolucionCodigoBarra = value; }
		}

		public int IdProgramacionJuego
		{
			get { return mIdProgramacionJuego; }
			set { mIdProgramacionJuego = value; }
		}

		public int IdVendedor
		{
			get { return mIdVendedor; }
			set { mIdVendedor = value; }
		}

		public string HojaCarton
		{
			get { return mHojaCarton; }
			set { mHojaCarton = value; }
		}

		public DateTime FechaHora
		{
			get { return mFechaHora; }
			set { mFechaHora = value; }
		}
	}
}
