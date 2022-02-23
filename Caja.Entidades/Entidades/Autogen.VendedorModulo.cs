using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class VendedorModulo
	{
		private int mIdVendedorModulo;

		private int mIdProgramacionJuego;

		private int mIdVendedor;

		private DateTime mFechaHora;

		private int mIdClienteModulo;

		private char mEstado;

		public VendedorModulo()
		{
		}

		public int IdVendedorModulo
		{
			get { return mIdVendedorModulo; }
			set { mIdVendedorModulo = value; }
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

		public DateTime FechaHora
		{
			get { return mFechaHora; }
			set { mFechaHora = value; }
		}

		public int IdClienteModulo
		{
			get { return mIdClienteModulo; }
			set { mIdClienteModulo = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}
	}
}
