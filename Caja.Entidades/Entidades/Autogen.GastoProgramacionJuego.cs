using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class GastoProgramacionJuego
	{
		private int mIdGastoJuego;

		private int mIdProgramacionJuego;

		private DateTime mFechaHora;

		private int mIdUsuario;

		private int mIdConceptoGasto;

		private string mDescripcion;

		private decimal mValor;

		private string mSocio;

		private char mEstado;

		public GastoProgramacionJuego()
		{
		}

		public int IdGastoJuego
		{
			get { return mIdGastoJuego; }
			set { mIdGastoJuego = value; }
		}

		public int IdProgramacionJuego
		{
			get { return mIdProgramacionJuego; }
			set { mIdProgramacionJuego = value; }
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

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}
	}
}
