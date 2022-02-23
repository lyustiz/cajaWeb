using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class VendedorReferencia
	{
		private int mIdVendedorReferencia;

		private int mIdVendedor;

		private int mIdTipoRelacion;

		private string mNombres;

		private string mApellidos;

		private string mDireccion;

		private string mTelefono;

		private string mCelular;

		private int mIdCiudad;

		private string mDocumento;

		private DateTime mFechaCreacion;

		private int mIdUsuarioCreacion;

		public VendedorReferencia()
		{
		}

		public int IdVendedorReferencia
		{
			get { return mIdVendedorReferencia; }
			set { mIdVendedorReferencia = value; }
		}

		public int IdVendedor
		{
			get { return mIdVendedor; }
			set { mIdVendedor = value; }
		}

		public int IdTipoRelacion
		{
			get { return mIdTipoRelacion; }
			set { mIdTipoRelacion = value; }
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
				
		public string Documento
		{
			get { return mDocumento; }
			set { mDocumento = value; }
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
