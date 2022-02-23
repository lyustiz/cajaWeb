using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class IngresoProgramacionJuego
	{
		private int mIdIngresoJuego;

		private int mIdProgramacionJuego;

		private DateTime mFechaHora;

		private int mIdUsuario;

		private int mIdConceptoIngreso;

		private string mDescripcion;

		private double mValor;

		private char mEstado;

		public IngresoProgramacionJuego()
		{
		}

		public int IdIngresoJuego
		{
			get { return mIdIngresoJuego; }
			set { mIdIngresoJuego = value; }
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

		public double Valor
		{
			get { return mValor; }
			set { mValor = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}
	}
}
