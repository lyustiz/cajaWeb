using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class Vendedor 
	{
		private int mIdVendedor;

		private string mCodigo;

		private string mNombres;		

		private string mApellidos;

		private string mDireccion;

		private string mTelefono;

		private string mCelular;
		
		private int mIdCiudad;

		private DateTime mFechaNacimiento;

		private int mIdEstadoCivil;

		private string mDocumento;

		private char mEstado;

		private DateTime mFechaCreacion;

		private int mIdUsuarioCreacion;

		public Vendedor()
		{
		}

		public int IdVendedor
		{
			get { return mIdVendedor; }
			set { mIdVendedor = value; }
		}

		public string Codigo
		{
			get { return mCodigo; }
			set { mCodigo = value; }
		}

		public string Nombres
		{
			get { return mNombres; }
			set { mNombres = value; }
		}
		
		public string Apellidos
		{
			get { return mApellidos; }
			set { mApellidos = value; }
		}

		public string Direccion
		{
			get { return mDireccion; }
			set { mDireccion = value; }
		}

		public string Telefono
		{
			get { return mTelefono; }
			set { mTelefono = value; }
		}

		public string Celular
		{
			get { return mCelular; }
			set { mCelular = value; }
		}

		public int IdCiudad
		{
			get { return mIdCiudad; }
			set { mIdCiudad = value; }
		}

		public DateTime FechaNacimiento
		{
			get { return mFechaNacimiento; }
			set { mFechaNacimiento = value; }
		}

		public int IdEstadoCivil
		{
			get { return mIdEstadoCivil; }
			set { mIdEstadoCivil = value; }
		}

		public string Documento
		{
			get { return mDocumento; }
			set { mDocumento = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}

		public DateTime FechaCreacion
		{
			get { return mFechaCreacion; }
			set { mFechaCreacion = value; }
		}

		public int IdUsuarioCreacion
		{
			get { return mIdUsuarioCreacion; }
			set { mIdUsuarioCreacion = value; }
		}
	}
}
