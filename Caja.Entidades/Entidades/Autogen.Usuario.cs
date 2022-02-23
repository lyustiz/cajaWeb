using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
    public partial class Usuario : IUsuario
	{
		private int mIdUsuario;

		private string mNombreCompleto;

		private string mLogin;

		private string mClave;

		private char mEstado;

		private bool mAutenticado;

		private DateTime mFechaCreacion;

		private string mJustificacionBloqueo;

		private DateTime? mFechaBloqueo;

		private DateTime? mFechaUltimoIngreso;

		private string mClaveAjustes;

		private bool mEsSocio;

		private bool mModificaPremios;

		private double mPorcentaje;

		public Usuario()
		{
		}

		public int IdUsuario
		{
			get { return mIdUsuario; }
			set { mIdUsuario = value; }
		}

		public string NombreCompleto
		{
			get { return mNombreCompleto; }
			set { mNombreCompleto = value; }
		}

		public string Login
		{
			get { return mLogin; }
			set { mLogin = value; }
		}

		public string Clave
		{
			get { return mClave; }
			set { mClave = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}

		public bool Autenticado
		{
			get { return mAutenticado; }
			set { mAutenticado = value; }
		}

		public DateTime FechaCreacion
		{
			get { return mFechaCreacion; }
			set { mFechaCreacion = value; }
		}

		public string JustificacionBloqueo
		{
			get { return mJustificacionBloqueo; }
			set { mJustificacionBloqueo = value; }
		}

		public DateTime? FechaBloqueo
		{
			get { return mFechaBloqueo; }
			set { mFechaBloqueo = value; }
		}

		public DateTime? FechaUltimoIngreso
		{
			get { return mFechaUltimoIngreso; }
			set { mFechaUltimoIngreso = value; }
		}

		public string ClaveAjustes
		{
			get { return mClaveAjustes; }
			set { mClaveAjustes = value; }
		}

		public bool EsSocio
		{
			get { return mEsSocio; }
			set { mEsSocio = value; }
		}

		public bool ModificaPremios
		{
			get { return mModificaPremios; }
			set { mModificaPremios = value; }
		}

		public double Porcentaje
		{
			get { return mPorcentaje; }
			set { mPorcentaje = value; }
		}
	}
}
