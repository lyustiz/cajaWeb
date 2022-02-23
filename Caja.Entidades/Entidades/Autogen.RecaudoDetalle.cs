using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class RecaudoDetalle
	{
		private int mIdRecaudoDetalle;

		private int mIdProgramacionJuego;

		private int mIdUsuario;

		private int mIdDefinicionMoneda;

		private int mCantidad;

		private double mTotalRecaudo;

		private char mEstado;

		private DateTime mFechaHora;

		public RecaudoDetalle()
		{
		}

		public int IdRecaudoDetalle
		{
			get { return mIdRecaudoDetalle; }
			set { mIdRecaudoDetalle = value; }
		}

		public int IdProgramacionJuego
		{
			get { return mIdProgramacionJuego; }
			set { mIdProgramacionJuego = value; }
		}

		public int IdUsuario
		{
			get { return mIdUsuario; }
			set { mIdUsuario = value; }
		}

		public int IdDefinicionMoneda
		{
			get { return mIdDefinicionMoneda; }
			set { mIdDefinicionMoneda = value; }
		}

		public int Cantidad
		{
			get { return mCantidad; }
			set { mCantidad = value; }
		}

		public double TotalRecaudo
		{
			get { return mTotalRecaudo; }
			set { mTotalRecaudo = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}

		public DateTime FechaHora
		{
			get { return mFechaHora; }
			set { mFechaHora = value; }
		}
	}
}
