using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class Perfil
	{
		private int mIdPerfil;

		private string mNombre;

		private string mDescripcion;


		public Perfil()
		{
		}

		public int IdPerfil
		{
			get { return mIdPerfil; }
			set { mIdPerfil = value; }
		}

		public string Nombre
		{
			get { return mNombre; }
			set { mNombre = value; }
		}

		public string Descripcion
		{
			get { return mDescripcion; }
			set { mDescripcion = value; }
		}
	}
}
