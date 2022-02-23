using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class DefinicionMoneda
	{
		private int mIdDefinicionMoneda;

		private string mMoneda;

		private string mTipo;

		private double mNominal;

		private double mEquivalencia;

		private int mGrupoSuma;

		public DefinicionMoneda()
		{
		}

		public int IdDefinicionMoneda
		{
			get { return mIdDefinicionMoneda; }
			set { mIdDefinicionMoneda = value; }
		}

		public string Moneda
		{
			get { return mMoneda; }
			set { mMoneda = value; }
		}

		public string Tipo
		{
			get { return mTipo; }
			set { mTipo = value; }
		}

		public double Nominal
		{
			get { return mNominal; }
			set { mNominal = value; }
		}

		public double Equivalencia
		{
			get { return mEquivalencia; }
			set { mEquivalencia = value; }
		}

		public int GrupoSuma
		{
			get { return mGrupoSuma; }
			set { mGrupoSuma = value; }
		}
	}
}
