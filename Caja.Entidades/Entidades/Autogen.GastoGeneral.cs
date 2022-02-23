using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class GastoGeneral
	{
		private int mIdGastoGeneral;

		private DateTime mFechaHora;

		private int mIdUsuario;

		private int mIdConceptoGasto;

		private string mDescripcion;

		private decimal mValor;

		private string mSocio;

		private DateTime mFechaRegistro;

		private byte mMes;

		private short mAnio;

		private char mOrigenPago;

		private char mEstado;

		public GastoGeneral()
		{
		}

		public int IdGastoGeneral
		{
			get { return mIdGastoGeneral; }
			set { mIdGastoGeneral = value; }
		}

		public DateTime FechaHora
		{
			get { return mFechaHora; }
			set { mFechaHora = value; }
		}

		public int IdUsuario
		{
			get { return mIdUsuario; }
			set { mIdUsuario = value; }
		}

		public int IdConceptoGasto
		{
			get { return mIdConceptoGasto; }
			set { mIdConceptoGasto = value; }
		}

		public string Descripcion
		{
			get { return mDescripcion; }
			set { mDescripcion = value; }
		}

		public decimal Valor
		{
			get { return mValor; }
			set { mValor = value; }
		}

		public string Socio
		{
			get { return mSocio; }
			set { mSocio = value; }
		}

		public DateTime FechaRegistro
		{
			get { return mFechaRegistro; }
			set { mFechaRegistro = value; }
		}

		public byte Mes
		{
			get { return mMes; }
			set { mMes = value; }
		}

		public short Anio
		{
			get { return mAnio; }
			set { mAnio = value; }
		}

		public char OrigenPago
		{
			get { return mOrigenPago; }
			set { mOrigenPago = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}
	}
}
