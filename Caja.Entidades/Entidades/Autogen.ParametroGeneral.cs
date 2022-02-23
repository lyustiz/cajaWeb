using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class ParametroGeneral
	{
		private int mIdParametros_Generales;

		private short? mIdEmpresa;

		private string mReferencia;

		private string mDescripcion;

		private string mValor;

		public ParametroGeneral()
		{
		}

		public int IdParametros_Generales
		{
			get { return mIdParametros_Generales; }
			set { mIdParametros_Generales = value; }
		}

		public short? IdEmpresa
		{
			get { return mIdEmpresa; }
			set { mIdEmpresa = value; }
		}

		public string Referencia
		{
			get { return mReferencia; }
			set { mReferencia = value; }
		}

		public string Descripcion
		{
			get { return mDescripcion; }
			set { mDescripcion = value; }
		}

		public string Valor
		{
			get { return mValor; }
			set { mValor = value; }
		}
	}
}
