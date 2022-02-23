using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class VendedorCuentaCobrar
	{
		private int mIdVendedorCuentaCobrar;

		private int mIdProgramacionJuego;

		private int mIdVendedor;

		private DateTime mFechaHora;

		private double mValor;

		private DateTime mFechaPago;

		private int mIdProgramacionJuegoPago;

		private char mEstado;

		public VendedorCuentaCobrar()
		{
		}

		public int IdVendedorCuentaCobrar
		{
			get { return mIdVendedorCuentaCobrar; }
			set { mIdVendedorCuentaCobrar = value; }
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

		public double Valor
		{
			get { return mValor; }
			set { mValor = value; }
		}

		public DateTime FechaPago
		{
			get { return mFechaPago; }
			set { mFechaPago = value; }
		}

		public int IdProgramacionJuegoPago
		{
			get { return mIdProgramacionJuegoPago; }
			set { mIdProgramacionJuegoPago = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}
	}
}
