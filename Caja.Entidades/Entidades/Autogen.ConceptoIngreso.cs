using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class ConceptoIngreso
	{
		private int mIdConceptoIngreso;

		private string mDescripcion;

		private double mValor;

		private short mSocios;

		public ConceptoIngreso()
		{
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

		public short Socios
		{
			get { return mSocios; }
			set { mSocios = value; }
		}
	}
}
