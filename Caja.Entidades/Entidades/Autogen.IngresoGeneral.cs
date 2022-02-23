using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class IngresoGeneral
	{
		private int mIdIngresoGeneral;

		private DateTime mFechaHora;

		private int mIdUsuario;

		private int mIdConceptoIngreso;

		private string mDescripcion;

		private decimal mValor;

		private string mSocio;

		private DateTime mFechaRegistro;

		private byte mMes;

		private short mAnio;

		private char mOrigenPago;

		private char mEstado;

		public IngresoGeneral()
		{
		}

		public int IdIngresoGeneral
		{
			get { return mIdIngresoGeneral; }
			set { mIdIngresoGeneral = value; }
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

		public int IdConceptoIngreso
		{
			get { return mIdConceptoIngreso; }
			set { mIdConceptoIngreso = value; }
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
