using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class HistoricoFlujoCaja
	{
		private int mIdHistoricoFlujoCaja;

		private DateTime mFechaHora;

		private int mIdUsuario;

		private byte mMes;

		private short mAnio;

		private char mOrigenPago;

		private decimal mValor;

		private string mAccion;

		private char mEstado;

		public HistoricoFlujoCaja()
		{
		}

		public int IdHistoricoFlujoCaja
		{
			get { return mIdHistoricoFlujoCaja; }
			set { mIdHistoricoFlujoCaja = value; }
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

		public decimal Valor
		{
			get { return mValor; }
			set { mValor = value; }
		}

		public string Accion
		{
			get { return mAccion; }
			set { mAccion = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}
	}
}
