using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class VendedorHoja
	{
		private int mIdVendedorHoja;

		private int mIdProgramacionJuego;

		private int mIdVendedor;

		private int mNumeroHoja;

		private char mEstado;

		public VendedorHoja()
		{
		}

		public int IdVendedorHoja
		{
			get { return mIdVendedorHoja; }
			set { mIdVendedorHoja = value; }
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

		public int NumeroHoja
		{
			get { return mNumeroHoja; }
			set { mNumeroHoja = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}
	}
}
