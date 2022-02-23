using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class RecaudoTotal
	{
		private string mNombreUsuario;

		private int mIdRecaudoTotal;

		private int mIdProgramacionJuego;

		private int mIdUsuario;

		private decimal mRecuadoTotal;

		private char mEstado;

		private DateTime mFechaHora;

		private decimal mValorRecaudoCalculado;

		private decimal mDiferencia;

		private int mIncluirGastosGenerales;

		private decimal mGastos;

		private decimal mIngresos;

		private int mRegistroGastos;

		private int mRegistroIngresos;

		public RecaudoTotal()
		{
		}
		public string NombreUsuario
		{
			get { return mNombreUsuario; }
			set { mNombreUsuario = value; }
		}

		public int IdRecaudoTotal
		{
			get { return mIdRecaudoTotal; }
			set { mIdRecaudoTotal = value; }
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

		public decimal RecuadoTotal
		{
			get { return mRecuadoTotal; }
			set { mRecuadoTotal = value; }
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

		public decimal ValorRecaudoCalculado
		{
			get { return mValorRecaudoCalculado; }
			set { mValorRecaudoCalculado = value; }
		}

		public decimal Diferencia
		{
			get { return mDiferencia; }
			set { mDiferencia = value; }
		}

		public int IncluirGastosGenerales
		{
			get { return mIncluirGastosGenerales; }
			set { mIncluirGastosGenerales = value; }
		}

		public decimal Gastos
		{
			get { return mGastos; }
			set { mGastos = value; }
		}

		public decimal Ingresos
		{
			get { return mIngresos; }
			set { mIngresos = value; }
		}

		public int RegistroGastos
		{
			get { return mRegistroGastos; }
			set { mRegistroGastos = value; }
		}

		public int RegistroIngresos
		{
			get { return mRegistroIngresos; }
			set { mRegistroIngresos = value; }
		}
	}
}
