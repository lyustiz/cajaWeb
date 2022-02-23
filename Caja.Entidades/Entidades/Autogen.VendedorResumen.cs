using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class VendedorResumen
	{
		private int mIdVendedorResumen;

		private int mIdProgramacionJuego;

		private int mIdVendedor;

		private int mTotalCartones;

		private int mCartonesCortesia;

		private double mValorTotal;

		private double mPagoAnticipado;

		private double mValorPendiente;

		private int mCartonesDevueltos;

		private int mNumeroHojasDevueltas;

		private double mPorcentajeComision;

		private double mCobrado;

		private double mFaltante;

		private double mGastoCortesia;

		private int mCantidadModulos;

		private double mValorModulos;

		private char mEstado;

		public VendedorResumen()
		{
		}

		public int IdVendedorResumen
		{
			get { return mIdVendedorResumen; }
			set { mIdVendedorResumen = value; }
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

		public int TotalCartones
		{
			get { return mTotalCartones; }
			set { mTotalCartones = value; }
		}

		public int CartonesCortesia
		{
			get { return mCartonesCortesia; }
			set { mCartonesCortesia = value; }
		}

		public double ValorTotal
		{
			get { return mValorTotal; }
			set { mValorTotal = value; }
		}

		public double PagoAnticipado
		{
			get { return mPagoAnticipado; }
			set { mPagoAnticipado = value; }
		}

		public double ValorPendiente
		{
			get { return mValorPendiente; }
			set { mValorPendiente = value; }
		}

		public int CartonesDevueltos
		{
			get { return mCartonesDevueltos; }
			set { mCartonesDevueltos = value; }
		}

		public int NumeroHojasDevueltas
		{
			get { return mNumeroHojasDevueltas; }
			set { mNumeroHojasDevueltas = value; }
		}

		public double PorcentajeComision
		{
			get { return mPorcentajeComision; }
			set { mPorcentajeComision = value; }
		}

		public double Cobrado
		{
			get { return mCobrado; }
			set { mCobrado = value; }
		}

		public double Faltante
		{
			get { return mFaltante; }
			set { mFaltante = value; }
		}

		public double GastoCortesia
		{
			get { return mGastoCortesia; }
			set { mGastoCortesia = value; }
		}

		public int CantidadModulos
		{
			get { return mCantidadModulos; }
			set { mCantidadModulos = value; }
		}

		public double ValorModulos
		{
			get { return mValorModulos; }
			set { mValorModulos = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}
	}
}
