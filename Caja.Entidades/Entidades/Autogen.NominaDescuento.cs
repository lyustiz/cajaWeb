using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class NominaDescuento
	{
		private int mIdNominaDescuento;

		private int mIdProgramacionJuego;

		private int mIdUsuario;

		private int mMes;

		private int mAnio;

		private string mConcepto;

		private decimal mValor;

		private char mCobrado;

		private char mEstado;

		private DateTime mFechaHora;

		public NominaDescuento()
		{
		}

		public int IdNominaDescuento
		{
			get { return mIdNominaDescuento; }
			set { mIdNominaDescuento = value; }
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

		public int Mes
		{
			get { return mMes; }
			set { mMes = value; }
		}

		public int Anio
		{
			get { return mAnio; }
			set { mAnio = value; }
		}

		public string Concepto
		{
			get { return mConcepto; }
			set { mConcepto = value; }
		}

		public decimal Valor
		{
			get { return mValor; }
			set { mValor = value; }
		}

		public char Cobrado
		{
			get { return mCobrado; }
			set { mCobrado = value; }
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
