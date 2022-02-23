using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class Ciudad
	{
		private int mIdCiudad;

		private int mIdPais;

		private string mDescripcion;


		public Ciudad()
		{
		}

		public int IdCiudad
		{
			get { return mIdCiudad; }
			set { mIdCiudad = value; }
		}

		public int IdPais
		{
			get { return mIdPais; }
			set { mIdPais = value; }
		}

		public string Descripcion
		{
			get { return mDescripcion; }
			set { mDescripcion = value; }
		}
	}
}
