using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class PerfilPermiso
	{
		private int mIdPerfilPermisos;

		private int mIdPerfil;

		private int mIdMenu;

		private bool mLectura;

		private bool mEscritura;

		private bool mEliminacion;

		private bool mHabilitado;

		public PerfilPermiso()
		{
		}

		public int IdPerfilPermisos
		{
			get { return mIdPerfilPermisos; }
			set { mIdPerfilPermisos = value; }
		}

		public int IdPerfil
		{
			get { return mIdPerfil; }
			set { mIdPerfil = value; }
		}

		public int IdMenu
		{
			get { return mIdMenu; }
			set { mIdMenu = value; }
		}

		public bool Lectura
		{
			get { return mLectura; }
			set { mLectura = value; }
		}

		public bool Escritura
		{
			get { return mEscritura; }
			set { mEscritura = value; }
		}

		public bool Eliminacion
		{
			get { return mEliminacion; }
			set { mEliminacion = value; }
		}

		public bool Habilitado
		{
			get { return mHabilitado; }
			set { mHabilitado = value; }
		}
	}
}
