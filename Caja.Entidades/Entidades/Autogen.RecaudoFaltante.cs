using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class RecaudoFaltante
	{
		private int mIdRecaudoFaltante;

		private int mIdProgramacionJuego;

		private int mIdUsuario;

		private DateTime mFechaHora;

		private int mIdVendedor;

		private char mEstado;

		private double mValorRecibido;

		public RecaudoFaltante()
		{
		}

		public int IdRecaudoFaltante
		{
			get { return mIdRecaudoFaltante; }
			set { mIdRecaudoFaltante = value; }
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

		public DateTime FechaHora
		{
			get { return mFechaHora; }
			set { mFechaHora = value; }
		}

		public int IdVendedor
		{
			get { return mIdVendedor; }
			set { mIdVendedor = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}

		public double ValorRecibido
		{
			get { return mValorRecibido; }
			set { mValorRecibido = value; }
		}
	}
}
